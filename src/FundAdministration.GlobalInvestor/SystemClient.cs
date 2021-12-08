using FundAdministration.GlobalInvestor.System;
using FundAdministration.GlobalInvestor.System.Triggers;

namespace FundAdministration.GlobalInvestor;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ITriggersService OutboundTriggerService => new TriggersService(_httpClient);
}
