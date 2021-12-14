using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ExchangeRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ForwardExchangeRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ForwardInterestRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.InterestRateTypes;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SecurityPrices;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SwapInterestRates;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SwapsPrices;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

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