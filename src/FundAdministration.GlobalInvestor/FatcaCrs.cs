using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace FundAdministration.GlobalInvestor;

public class FatcaCrs : IFatcaCrs
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public FatcaCrs(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IFatcaCrsDocumentsService DocumentService => new FatcaCrsDocumentsService(_httpClient){BaseUrl = BaseUrl};

    public IFatcaCrsStatusesService StatusService => new FatcaCrsStatusesService(_httpClient){BaseUrl = BaseUrl};

    public IFatcaCrsSubStatusesService SubStatusService => new FatcaCrsSubStatusesService(_httpClient){BaseUrl = BaseUrl};
}
