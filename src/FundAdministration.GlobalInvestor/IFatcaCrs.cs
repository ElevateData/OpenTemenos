using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace FundAdministration.GlobalInvestor;

public interface IFatcaCrs
{
    public IFatcaCrsDocumentService DocumentService { get; }
    public IFatcaCrsStatuseService StatuService { get; }
    public IFatcaCrsSubStatuseService SubStatuService { get; }
}
