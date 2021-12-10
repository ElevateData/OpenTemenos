using FundAdministration.GlobalAccounting.Reference;
using FundAdministration.GlobalAccounting.Reference.ExchangeRates;
using FundAdministration.GlobalAccounting.Reference.ForwardExchangeRates;
using FundAdministration.GlobalAccounting.Reference.ForwardInterestRates;
using FundAdministration.GlobalAccounting.Reference.InterestRateTypes;
using FundAdministration.GlobalAccounting.Reference.SecurityPrices;
using FundAdministration.GlobalAccounting.Reference.SwapInterestRates;
using FundAdministration.GlobalAccounting.Reference.SwapsPrices;

namespace FundAdministration.GlobalAccounting;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForwardExchangeRateService ForwardExchangeRateService => new ForwardExchangeRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForwardInterestRateService ForwardInterestRateService => new ForwardInterestRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInterestRateTypeService InterestRateTypeService => new InterestRateTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityPriceService SecurityPriceService => new SecurityPriceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISwapInterestRateService SwapInterestRateService => new SwapInterestRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISwapsPriceService SwapsPriceService => new SwapsPriceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
