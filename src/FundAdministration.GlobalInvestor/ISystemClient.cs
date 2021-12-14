using OpenTemenos.FundAdministrations.GlobalInvestor.System.Triggers;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public interface ISystemClient
{
    public ITriggerService OutboundTriggerService { get; }
}