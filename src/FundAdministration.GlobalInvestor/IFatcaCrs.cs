using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace FundAdministration.GlobalInvestor;

public interface IFatcaCrs
{
    public IFatcaCrsDocumentsService DocumentService { get; }
    public IFatcaCrsStatusesService StatusService { get; }
    public IFatcaCrsSubStatusesService SubStatusService { get; }
}
