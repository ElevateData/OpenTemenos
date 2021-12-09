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