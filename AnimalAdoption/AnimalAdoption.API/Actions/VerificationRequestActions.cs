using AnimalAdoption.API.ViewModels;
using AnimalAdoption.DAL.IRepositories;
using AnimalAdoption.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.Actions
{
    public class VerificationRequestActions
    {
        private readonly IGenericRepos<VerificationRequest> _verification;
        public VerificationRequestActions(IGenericRepos<VerificationRequest> verification)
        {
            _verification = verification;
        }

        public async Task SendVerificationRequest(VerificationRequestVM verificationRequest)
        {
            VerificationRequest verification = await _verification.GetAll()
                .Where(x => x.RequesterId == verificationRequest.UserId)
                .FirstOrDefaultAsync();
            if (verificationRequest.FormFile != null)
            {
                verificationRequest.PassportUrl = await verificationRequest.FormFile.SaveImage("Passports");
            }
            if (verification == null)
            {
                await AddVerificationRequest(verificationRequest);
            }
            else
            {
                await UpdateVerificationRequest(verificationRequest, verification);
            }
        }

        public async Task AddVerificationRequest(VerificationRequestVM verificationRequest)
        {
            VerificationRequest verification = new VerificationRequest
            {
                PassportUrl = verificationRequest.PassportUrl,
                RequesterId = verificationRequest.UserId,
                PhoneNumber = verificationRequest.PhoneNumber,
                IsVerified = false,
                RequestDate = DateTime.Now
            };
            await _verification.Create(verification);
        }

        public async Task UpdateVerificationRequest(VerificationRequestVM verificationRequest, VerificationRequest dbVerification)
        {
            dbVerification.PassportUrl = verificationRequest.PassportUrl;
            dbVerification.RequesterId = verificationRequest.UserId;
            dbVerification.PhoneNumber = verificationRequest.PhoneNumber;
            dbVerification.IsVerified = false;
            await _verification.Update(dbVerification);
        }

        public async Task<bool> AlreadyVerified(string UserId)
        {
            return await _verification.GetAll()
                .AnyAsync(x => x.IsVerified && x.RequesterId == UserId);
        }

        public async Task<bool> AlreadyRequested(string UserId)
        {
            return await _verification.GetAll()
                .AnyAsync(x => x.RequesterId == UserId);
        }
    }
}
