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

public interface ISystemClient
{
    public ICloudServiceElasticityService CloudServiceElasticityService { get; }
    public IDataEventStreamingService DataEventStreamingService { get; }
    public IExternalAccountingService ExternalAccountingService { get; }
    public IDocumentRequiredService DocumentRequiredService { get; }
    public ISPFInformationService SPFInformationService { get; }
    public IUsageStatisticsService UsageStatisticsService { get; }
    public IOnlineUpgradeService OnlineUpgradeService { get; }
    public IProcessWorkFlowService ProcessWorkFlowService { get; }
    public IServiceAutomationService ServiceAutomationService { get; }
}