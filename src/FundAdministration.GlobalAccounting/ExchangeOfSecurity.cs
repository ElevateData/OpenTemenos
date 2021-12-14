using OpenTemenos.FundAdministrations.GlobalAccounting.Holding;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosCashCompensations;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosMultipleSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosSameSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public class ExchangeOfSecurity : IExchangeOfSecurity
{
    private readonly HttpClient _httpClient;

    public ExchangeOfSecurity(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IExchangeOfNewSecurityWithCashOutflowService NewSecurityWithCashOutflowService =>
        new ExchangeOfNewSecurityWithCashOutflowService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeOfNewSecurityWithCashInflowService NewSecurityWithCashInflowService =>
        new ExchangeOfNewSecurityWithCashInflowService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosNewSecurityWithoutCashService NewSecurityWithoutCashCompensationService =>
        new EosNewSecurityWithoutCashService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosCashCompensationService NewSecurityWithCashCompensationService =>
        new EosCashCompensationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosSameSecurityService SameSecurityService => new EosSameSecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosMultipleSecurityService MultipleSecurityService => new EosMultipleSecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}