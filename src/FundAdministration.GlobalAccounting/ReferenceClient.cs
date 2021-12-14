using OpenTemenos.FundAdministrations.GlobalAccounting.Reference;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ExchangeRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ForwardExchangeRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ForwardInterestRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.InterestRateTypes;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SecurityPrices;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SwapInterestRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SwapsPrices;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForwardExchangeRateService ForwardExchangeRateService => new ForwardExchangeRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForwardInterestRateService ForwardInterestRateService => new ForwardInterestRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInterestRateTypeService InterestRateTypeService => new InterestRateTypeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityPriceService SecurityPriceService => new SecurityPriceService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapInterestRateService SwapInterestRateService => new SwapInterestRateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapsPriceService SwapsPriceService => new SwapsPriceService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}