using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace FundAdministration.GlobalInvestor;

public class FatcaCrs : IFatcaCrs
{
    private readonly HttpClient _httpClient;

    public FatcaCrs(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IFatcaCrsDocumentsService DocumentService => new FatcaCrsDocumentsService(_httpClient);

    public IFatcaCrsStatusesService StatusService => new FatcaCrsStatusesService(_httpClient);

    public IFatcaCrsSubStatusesService SubStatusService => new FatcaCrsSubStatusesService(_httpClient);
}
