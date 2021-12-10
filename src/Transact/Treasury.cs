using Transact.Holding;
using Transact.Holding.CreateNonDeliverableForwards;
using Transact.Holding.CurrencyPositions;
using Transact.Holding.Positions;
using Transact.Holding.Reports;
using Transact.Holding.SwapNpvRevaluations;
using Transact.Holding.TreasuryCurrencies;
using Transact.Holding.TreasuryCurrencyPairs;

namespace Transact;

public class Treasury : ITreasury
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public Treasury(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITreasuryCurrencyPairService CurrencyPairService => new TreasuryCurrencyPairService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISwapNpvRevaluationService InterestRateSwapRevaluationService => new SwapNpvRevaluationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITreasuryCurrencyService LiveRateService => new TreasuryCurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICreateNonDeliverableForwardService NonDeliverableForwardService =>
        new CreateNonDeliverableForwardService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPositionService PositionService => new PositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReportService ReportService => new ReportService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrencyPositionService CurrencyPositionService => new CurrencyPositionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
