using Transact.Holding.CreateNonDeliverableForwards;
using Transact.Holding.CurrencyPosition;
using Transact.Holding.Position;
using Transact.Holding.Reports;
using Transact.Holding.SwapNpvRevaluation;
using Transact.Holding.TreasuryCurrencies;
using Transact.Holding.TreasuryCurrencyPairs;

namespace Transact;

public interface ITreasury
{
    public ITreasuryCurrencyPairsService CurrencyPairService { get; }
    public ISwapNpvRevaluationService InterestRateSwapRevaluationService { get; }
    public ITreasuryCurrenciesService LiveRateService { get; }
    public ICreateNonDeliverableForwardsService NonDeliverableForwardService { get; }
    public IPositionService PositionService { get; }
    public IReportsService ReportService { get; }
    public ICurrencyPositionService CurrencyPositionService { get; }
}
