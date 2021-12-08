﻿using FundAdministration.GlobalInvestor.Product;
using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using FundAdministration.GlobalInvestor.Product.Security;
using FundAdministration.GlobalInvestor.Product.SecurityDesc;
using FundAdministration.GlobalInvestor.Product.ShareValues;

namespace FundAdministration.GlobalInvestor;

public class MasterFund : IMasterFund
{
    private readonly HttpClient _httpClient;

    public MasterFund(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ISecurityDescService SecurityDescriptionService => new SecurityDescService(_httpClient);

    public IShareValuesService ShareValueService => new ShareValuesService(_httpClient);

    public IMinDivPaymentsService MinDividendPaymentService => new MinDivPaymentsService(_httpClient);

    public ISecurityService SecurityService => new SecurityService(_httpClient);
}