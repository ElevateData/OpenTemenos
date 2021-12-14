using OpenTemenos.FundAdministrations.GlobalInvestor.System;
using OpenTemenos.FundAdministrations.GlobalInvestor.System.Triggers;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public ITriggerService OutboundTriggerService => new TriggerService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}