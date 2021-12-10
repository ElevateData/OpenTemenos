using FundAdministration.GlobalAccounting.Holding;
using FundAdministration.GlobalAccounting.Holding.EosCashCompensations;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurities;
using FundAdministration.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using FundAdministration.GlobalAccounting.Holding.EosSameSecurities;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;

namespace FundAdministration.GlobalAccounting;

public class ExchangeOfSecurity : IExchangeOfSecurity
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ExchangeOfSecurity(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IExchangeOfNewSecurityWithCashOutflowService NewSecurityWithCashOutflowService =>
        new ExchangeOfNewSecurityWithCashOutflowService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeOfNewSecurityWithCashInflowService NewSecurityWithCashInflowService =>
        new ExchangeOfNewSecurityWithCashInflowService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosNewSecurityWithoutCashService NewSecurityWithoutCashCompensationService =>
        new EosNewSecurityWithoutCashService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosCashCompensationService NewSecurityWithCashCompensationService =>
        new EosCashCompensationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosSameSecurityService SameSecurityService => new EosSameSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosMultipleSecurityService MultipleSecurityService => new EosMultipleSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
