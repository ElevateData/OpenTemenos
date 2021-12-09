using FundAdministration.GlobalInvestor.System;
using FundAdministration.GlobalInvestor.System.Triggers;

namespace FundAdministration.GlobalInvestor;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITriggersService OutboundTriggerService => new TriggersService(_httpClient){BaseUrl = BaseUrl};
}
