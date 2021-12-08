using Transact.Holding;
using Transact.Holding.CreateNonDeliverableForwards;
using Transact.Holding.CurrencyPosition;
using Transact.Holding.Position;
using Transact.Holding.Reports;
using Transact.Holding.SwapNpvRevaluation;
using Transact.Holding.TreasuryCurrencies;
using Transact.Holding.TreasuryCurrencyPairs;

namespace Transact;

public class Treasury : ITreasury
{
    private readonly HttpClient _httpClient;

    public Treasury(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITreasuryCurrencyPairsService CurrencyPairService => new TreasuryCurrencyPairsService(_httpClient);

    public ISwapNpvRevaluationService InterestRateSwapRevaluationService => new SwapNpvRevaluationService(_httpClient);

    public ITreasuryCurrenciesService LiveRateService => new TreasuryCurrenciesService(_httpClient);

    public ICreateNonDeliverableForwardsService NonDeliverableForwardService =>
        new CreateNonDeliverableForwardsService(_httpClient);

    public IPositionService PositionService => new PositionService(_httpClient);

    public IReportsService ReportService => new ReportsService(_httpClient);

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient);
}
