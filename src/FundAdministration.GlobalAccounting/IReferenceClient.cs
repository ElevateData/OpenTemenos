using FundAdministration.GlobalAccounting.Reference.ExchangeRates;
using FundAdministration.GlobalAccounting.Reference.ForwardExchangeRates;
using FundAdministration.GlobalAccounting.Reference.ForwardInterestRates;
using FundAdministration.GlobalAccounting.Reference.InterestRateTypes;
using FundAdministration.GlobalAccounting.Reference.SecurityPrices;
using FundAdministration.GlobalAccounting.Reference.SwapInterestRates;
using FundAdministration.GlobalAccounting.Reference.SwapsPrices;

namespace FundAdministration.GlobalAccounting;

public interface IReferenceClient
{
    public IExchangeRateService ExchangeRateService { get; }
    public IForwardExchangeRateService ForwardExchangeRateService { get; }
    public IForwardInterestRateService ForwardInterestRateService { get; }
    public IInterestRateTypeService InterestRateTypeService { get; }
    public ISecurityPriceService SecurityPriceService { get; }
    public ISwapInterestRateService SwapInterestRateService { get; }
    public ISwapsPriceService SwapsPriceService { get; }
}
