using OpenTemenos.FundAdministrations.GlobalInvestor.Party;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaCrsDocuments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaCrsStatuses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaCrsSubStatuses;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class FatcaCrs : IFatcaCrs
{
    private readonly HttpClient _httpClient;

    public FatcaCrs(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IFatcaCrsDocumentService DocumentService => new FatcaCrsDocumentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrsStatuseService StatuService => new FatcaCrsStatuseService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrsSubStatuseService SubStatuService => new FatcaCrsSubStatuseService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}