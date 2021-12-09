using FundAdministration.GlobalAccounting.Holding;
using FundAdministration.GlobalAccounting.Holding.EosCashCompensation;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurity;
using FundAdministration.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using FundAdministration.GlobalAccounting.Holding.EosSameSecurity;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflow;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflow;

namespace FundAdministration.GlobalAccounting;

public class ExchangeOfSecurity : IExchangeOfSecurity
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public ExchangeOfSecurity(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IExchangeOfNewSecurityWithCashOutflowService NewSecurityWithCashOutflowService =>
        new ExchangeOfNewSecurityWithCashOutflowService(_httpClient){BaseUrl = BaseUrl};

    public IExchangeOfNewSecurityWithCashInflowService NewSecurityWithCashInflowService =>
        new ExchangeOfNewSecurityWithCashInflowService(_httpClient){BaseUrl = BaseUrl};

    public IEosNewSecurityWithoutCashService NewSecurityWithoutCashCompensationService =>
        new EosNewSecurityWithoutCashService(_httpClient){BaseUrl = BaseUrl};

    public IEosCashCompensationService NewSecurityWithCashCompensationService =>
        new EosCashCompensationService(_httpClient){BaseUrl = BaseUrl};

    public IEosSameSecurityService SameSecurityService => new EosSameSecurityService(_httpClient){BaseUrl = BaseUrl};

    public IEosMultipleSecurityService MultipleSecurityService => new EosMultipleSecurityService(_httpClient){BaseUrl = BaseUrl};
}
