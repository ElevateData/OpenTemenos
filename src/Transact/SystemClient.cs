using Transact.System;
using Transact.System.CloudServiceElasticity;
using Transact.System.DataEventStreaming;
using Transact.System.DocumentRequired;
using Transact.System.ExternalAccounting;
using Transact.System.OnlineUpgrade;
using Transact.System.ProcessWorkFlow;
using Transact.System.ServiceAutomation;
using Transact.System.SPFInformation;
using Transact.System.UsageStatistics;

namespace Transact;

public class SystemClient : ISystemClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICloudServiceElasticityService CloudServiceElasticityService => new CloudServiceElasticityService(_httpClient){BaseUrl = BaseUrl};
    public IDataEventStreamingService DataEventStreamingService => new DataEventStreamingService(_httpClient){BaseUrl = BaseUrl};
    public IExternalAccountingService ExternalAccountingService => new ExternalAccountingService(_httpClient){BaseUrl = BaseUrl};
    public IDocumentRequiredService DocumentRequiredService => new DocumentRequiredService(_httpClient){BaseUrl = BaseUrl};
    public ISPFInformationService SPFInformationService => new SPFInformationService(_httpClient){BaseUrl = BaseUrl};
    public IUsageStatisticsService UsageStatisticsService => new UsageStatisticsService(_httpClient){BaseUrl = BaseUrl};
    public IOnlineUpgradeService OnlineUpgradeService => new OnlineUpgradeService(_httpClient){BaseUrl = BaseUrl};
    public IProcessWorkFlowService ProcessWorkFlowService => new ProcessWorkFlowService(_httpClient){BaseUrl = BaseUrl};
    public IServiceAutomationService ServiceAutomationService => new ServiceAutomationService(_httpClient){BaseUrl = BaseUrl};
}
