using FundAdministration.GlobalInvestor.Party.AmlBlocks;
using FundAdministration.GlobalInvestor.Party.AmlDocuments;
using FundAdministration.GlobalInvestor.Party.AmlMonitorBlocks;

namespace FundAdministration.GlobalInvestor;

public interface IAntiMoneyLaundering
{
    public IAmlBlockService AmlBlockService { get; }
    public IAmlDocumentService AmlDocumentService { get; }
    public IAmlMonitorBlockService AmlMonitorBlockService { get; }

}
