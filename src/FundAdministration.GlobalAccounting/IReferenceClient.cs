using FundAdministration.GlobalAccounting.Reference.ExchangeRate;
using FundAdministration.GlobalAccounting.Reference.ForwardExchangeRate;
using FundAdministration.GlobalAccounting.Reference.ForwardInterestRate;
using FundAdministration.GlobalAccounting.Reference.InterestRateType;
using FundAdministration.GlobalAccounting.Reference.SecurityPrice;
using FundAdministration.GlobalAccounting.Reference.SwapInterestRate;
using FundAdministration.GlobalAccounting.Reference.SwapsPrice;

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
