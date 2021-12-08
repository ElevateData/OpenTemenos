using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalInvestor;

namespace OpenTemenos;

public interface IFundAdministration
{
    public IGlobalAccountingClient GlobalAccountingClient { get; }
    public IGlobalInvestorClient GlobalInvestorClient { get; }
}