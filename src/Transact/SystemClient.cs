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

    public SystemClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICloudServiceElasticityService CloudServiceElasticityService => new CloudServiceElasticityService(_httpClient);
    public IDataEventStreamingService DataEventStreamingService => new DataEventStreamingService(_httpClient);
    public IExternalAccountingService ExternalAccountingService => new ExternalAccountingService(_httpClient);
    public IDocumentRequiredService DocumentRequiredService => new DocumentRequiredService(_httpClient);
    public ISPFInformationService SPFInformationService => new SPFInformationService(_httpClient);
    public IUsageStatisticsService UsageStatisticsService => new UsageStatisticsService(_httpClient);
    public IOnlineUpgradeService OnlineUpgradeService => new OnlineUpgradeService(_httpClient);
    public IProcessWorkFlowService ProcessWorkFlowService => new ProcessWorkFlowService(_httpClient);
    public IServiceAutomationService ServiceAutomationService => new ServiceAutomationService(_httpClient);
}
