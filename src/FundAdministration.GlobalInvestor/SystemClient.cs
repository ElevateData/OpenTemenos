using FundAdministration.GlobalInvestor.System;
using FundAdministration.GlobalInvestor.System.Triggers;

namespace FundAdministration.GlobalInvestor;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITriggerService OutboundTriggerService => new TriggerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
