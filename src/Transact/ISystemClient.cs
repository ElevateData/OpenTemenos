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

public interface ISystemClient
{
    public ICloudServiceElasticityService CloudServiceElasticityService { get; }
    public IDataEventStreamingService DataEventStreamingService { get; }
    public IExternalAccountingService ExternalAccountingService { get; }
    public IDocumentRequiredService DocumentRequiredService { get; }
    public ISPFInformationService SPFInformationService { get; }
    public IUsageStatisticService UsageStatisticService { get; }
    public IOnlineUpgradeService OnlineUpgradeService { get; }
    public IProcessWorkFlowService ProcessWorkFlowService { get; }
    public IServiceAutomationService ServiceAutomationService { get; }
}