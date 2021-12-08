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

    public ExchangeOfSecurity(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IExchangeOfNewSecurityWithCashOutflowService NewSecurityWithCashOutflowService =>
        new ExchangeOfNewSecurityWithCashOutflowService(_httpClient);

    public IExchangeOfNewSecurityWithCashInflowService NewSecurityWithCashInflowService =>
        new ExchangeOfNewSecurityWithCashInflowService(_httpClient);

    public IEosNewSecurityWithoutCashService NewSecurityWithoutCashCompensationService =>
        new EosNewSecurityWithoutCashService(_httpClient);

    public IEosCashCompensationService NewSecurityWithCashCompensationService =>
        new EosCashCompensationService(_httpClient);

    public IEosSameSecurityService SameSecurityService => new EosSameSecurityService(_httpClient);

    public IEosMultipleSecurityService MultipleSecurityService => new EosMultipleSecurityService(_httpClient);
}
