using OpenTemenos.FundAdministrations.GlobalInvestor.Party;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlBlocks;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlDocuments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlMonitorBlocks;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class AntiMoneyLaundering : IAntiMoneyLaundering
{
    private readonly HttpClient _httpClient;

    public AntiMoneyLaundering(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAmlBlockService AmlBlockService => new AmlBlockService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAmlDocumentService AmlDocumentService => new AmlDocumentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAmlMonitorBlockService AmlMonitorBlockService => new AmlMonitorBlockService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}