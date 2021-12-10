using Transact.System;
using Transact.System.CloudServiceElasticities;
using Transact.System.DataEventStreamings;
using Transact.System.DocumentRequireds;
using Transact.System.ExternalAccountings;
using Transact.System.OnlineUpgrades;
using Transact.System.ProcessWorkFlows;
using Transact.System.ServiceAutomations;
using Transact.System.SPFInformations;
using Transact.System.UsageStatistics;

namespace Transact;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICloudServiceElasticityService CloudServiceElasticityService => new CloudServiceElasticityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDataEventStreamingService DataEventStreamingService => new DataEventStreamingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExternalAccountingService ExternalAccountingService => new ExternalAccountingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDocumentRequiredService DocumentRequiredService => new DocumentRequiredService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISPFInformationService SPFInformationService => new SPFInformationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsageStatisticService UsageStatisticService => new UsageStatisticService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOnlineUpgradeService OnlineUpgradeService => new OnlineUpgradeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProcessWorkFlowService ProcessWorkFlowService => new ProcessWorkFlowService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IServiceAutomationService ServiceAutomationService => new ServiceAutomationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
