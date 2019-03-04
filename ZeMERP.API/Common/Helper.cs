using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Erp.Api.Common
{
    public static class Helper
    {
        public static object GenerateJwtToken(string email, IdentityUser user, IConfiguration _configuration)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
    //GL Enumeration
    public enum Class
    {
        Assets = 1,
        Equity,
        Expenses,
        Income,
        Liability
    };
    public enum ChartOfAccountLevel
    {
        Group,
        Control,
        Detail
    };
    public enum AccountType
    {
        None,
        Bank,
        Cash,
        Clearing
    };
    public enum AnalysisCode
    {
        Asset = 1,
        Customer,
        Department,
        Employee,
        Item,
        Location,
        Product,
        Project,
        Supplier,
        Vehicle    
    };
    public enum CoaEnableOn
    {
        Both = 'B',
        Credit = 'C',
        Debit = 'D'
    };
    public enum CustomerType
    {
        Foreign = 'F',
        Local = 'L',
        Purchaser = 'P'
    };
    public enum SupplierType
    {
        Foreign = 'F',
        Local = 'L',
        Purchaser = 'P'
    };
    public enum TerritoryLevel
    {
        Region,
        Zone,
        City,
        Location
    };
    //Transactions
    public enum WorkFlowStatus
    {
        UnApproved,
        Approved,
        Posted
    };
    public enum VoucherType
    {
        BankPaymentVoucher = 1,
        BankReceiptVoucher,
        CashPaymentVoucher,
        CashReceiptVoucher,
        JournalVoucher,
        PurchaseJournalVoucher,
        SalesJournalVoucher 
    };
    public enum ContactType
    {
        Customer = 1,
        Supplier
    };
}
