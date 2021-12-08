using FundAdministration.GlobalAccounting.Reference;
using FundAdministration.GlobalAccounting.Reference.ExchangeRate;
using FundAdministration.GlobalAccounting.Reference.ForwardExchangeRate;
using FundAdministration.GlobalAccounting.Reference.ForwardInterestRate;
using FundAdministration.GlobalAccounting.Reference.InterestRateType;
using FundAdministration.GlobalAccounting.Reference.SecurityPrice;
using FundAdministration.GlobalAccounting.Reference.SwapInterestRate;
using FundAdministration.GlobalAccounting.Reference.SwapsPrice;

namespace FundAdministration.GlobalAccounting;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IExchangeRateService ExchangeRateService => new ExchangeRateService(_httpClient);
    public IForwardExchangeRateService ForwardExchangeRateService => new ForwardExchangeRateService(_httpClient);
    public IForwardInterestRateService ForwardInterestRateService => new ForwardInterestRateService(_httpClient);
    public IInterestRateTypeService InterestRateTypeService => new InterestRateTypeService(_httpClient);
    public ISecurityPriceService SecurityPriceService => new SecurityPriceService(_httpClient);
    public ISwapInterestRateService SwapInterestRateService => new SwapInterestRateService(_httpClient);
    public ISwapsPriceService SwapsPriceService => new SwapsPriceService(_httpClient);
}
