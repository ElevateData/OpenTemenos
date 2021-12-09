using Transact.SystemX;
using Transact.SystemX.CloudServiceElasticity;
using Transact.SystemX.DataEventStreaming;
using Transact.SystemX.DocumentRequired;
using Transact.SystemX.ExternalAccounting;
using Transact.SystemX.OnlineUpgrade;
using Transact.SystemX.ProcessWorkFlow;
using Transact.SystemX.ServiceAutomation;
using Transact.SystemX.SPFInformation;
using Transact.SystemX.UsageStatistics;

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
