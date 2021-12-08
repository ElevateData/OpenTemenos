using FundAdministration.GlobalInvestor.Party.AmlBlocks;
using FundAdministration.GlobalInvestor.Party.AmlDocuments;
using FundAdministration.GlobalInvestor.Party.AmlMonitorBlocks;

namespace FundAdministration.GlobalInvestor;

public interface IAntiMoneyLaundering
{
    public IAmlBlocksService AmlBlocksService { get; }
    public IAmlDocumentsService AmlDocumentsService { get; }
    public IAmlMonitorBlocksService AmlMonitorBlocksService { get; }

}
