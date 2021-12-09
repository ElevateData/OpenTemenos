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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public Treasury(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITreasuryCurrencyPairsService CurrencyPairService => new TreasuryCurrencyPairsService(_httpClient) { BaseUrl = BaseUrl };

    public ISwapNpvRevaluationService InterestRateSwapRevaluationService => new SwapNpvRevaluationService(_httpClient) { BaseUrl = BaseUrl };

    public ITreasuryCurrenciesService LiveRateService => new TreasuryCurrenciesService(_httpClient) { BaseUrl = BaseUrl };

    public ICreateNonDeliverableForwardsService NonDeliverableForwardService =>
        new CreateNonDeliverableForwardsService(_httpClient) { BaseUrl = BaseUrl };

    public IPositionService PositionService => new PositionService(_httpClient) { BaseUrl = BaseUrl };

    public IReportsService ReportService => new ReportsService(_httpClient) { BaseUrl = BaseUrl };

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient) { BaseUrl = BaseUrl };
}
