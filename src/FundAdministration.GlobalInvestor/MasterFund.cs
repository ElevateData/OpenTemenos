using FundAdministration.GlobalInvestor.Product;
using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using FundAdministration.GlobalInvestor.Product.Security;
using FundAdministration.GlobalInvestor.Product.SecurityDesc;
using FundAdministration.GlobalInvestor.Product.ShareValues;

namespace FundAdministration.GlobalInvestor;

public class MasterFund : IMasterFund
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public MasterFund(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ISecurityDescService SecurityDescriptionService => new SecurityDescService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IShareValuesService ShareValueService => new ShareValuesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMinDivPaymentsService MinDividendPaymentService => new MinDivPaymentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityService SecurityService => new SecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
