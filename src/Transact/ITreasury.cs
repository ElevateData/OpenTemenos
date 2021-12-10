using Transact.Holding.CreateNonDeliverableForwards;
using Transact.Holding.CurrencyPositions;
using Transact.Holding.Positions;
using Transact.Holding.Reports;
using Transact.Holding.SwapNpvRevaluations;
using Transact.Holding.TreasuryCurrencies;
using Transact.Holding.TreasuryCurrencyPairs;

namespace Transact;

public interface ITreasury
{
    public ITreasuryCurrencyPairService CurrencyPairService { get; }
    public ISwapNpvRevaluationService InterestRateSwapRevaluationService { get; }
    public ITreasuryCurrencyService LiveRateService { get; }
    public ICreateNonDeliverableForwardService NonDeliverableForwardService { get; }
    public IPositionService PositionService { get; }
    public IReportService ReportService { get; }
    public ICurrencyPositionService CurrencyPositionService { get; }
}
