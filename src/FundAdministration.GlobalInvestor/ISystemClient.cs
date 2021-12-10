using FundAdministration.GlobalInvestor.System.Triggers;

namespace FundAdministration.GlobalInvestor;

public interface ISystemClient
{
    public ITriggerService OutboundTriggerService { get; }
}
