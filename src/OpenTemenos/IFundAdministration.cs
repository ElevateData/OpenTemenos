using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalInvestor;

namespace OpenTemenos;

public interface IFundAdministration
{
    public IGlobalAccountingClient GlobalAccountingClient { get; }
    public IGlobalInvestorClient GlobalInvestorClient { get; }
}