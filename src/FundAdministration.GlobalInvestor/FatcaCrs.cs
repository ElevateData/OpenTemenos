using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace FundAdministration.GlobalInvestor;

public class FatcaCrs : IFatcaCrs
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public FatcaCrs(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IFatcaCrsDocumentService DocumentService => new FatcaCrsDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrsStatuseService StatuService => new FatcaCrsStatuseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrsSubStatuseService SubStatuService => new FatcaCrsSubStatuseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
