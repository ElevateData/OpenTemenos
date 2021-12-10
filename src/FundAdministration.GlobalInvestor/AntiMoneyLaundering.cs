using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.AmlBlocks;
using FundAdministration.GlobalInvestor.Party.AmlDocuments;
using FundAdministration.GlobalInvestor.Party.AmlMonitorBlocks;

namespace FundAdministration.GlobalInvestor;

public class AntiMoneyLaundering : IAntiMoneyLaundering
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public AntiMoneyLaundering(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAmlBlockService AmlBlockService => new AmlBlockService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAmlDocumentService AmlDocumentService => new AmlDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAmlMonitorBlockService AmlMonitorBlockService => new AmlMonitorBlockService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
