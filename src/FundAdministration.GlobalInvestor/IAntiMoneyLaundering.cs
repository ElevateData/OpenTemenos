using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlBlocks;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlDocuments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlMonitorBlocks;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public interface IAntiMoneyLaundering
{
    public IAmlBlockService AmlBlockService { get; }
    public IAmlDocumentService AmlDocumentService { get; }
    public IAmlMonitorBlockService AmlMonitorBlockService { get; }
}