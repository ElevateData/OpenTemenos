using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaCrsDocuments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaCrsStatuses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public interface IFatcaCrs
{
    public IFatcaCrsDocumentService DocumentService { get; }
    public IFatcaCrsStatuseService StatuService { get; }
    public IFatcaCrsSubStatuseService SubStatuService { get; }
}