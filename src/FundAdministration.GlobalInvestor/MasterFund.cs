using OpenTemenos.FundAdministrations.GlobalInvestor.Product;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.MinDivPayments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.Securities;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SecurityDescs;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ShareValues;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class MasterFund : IMasterFund
{
    private readonly HttpClient _httpClient;

    public MasterFund(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public ISecurityDescService SecurityDescriptionService => new SecurityDescService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IShareValueService ShareValueService => new ShareValueService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMinDivPaymentService MinDividendPaymentService => new MinDivPaymentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityService SecurityService => new SecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}