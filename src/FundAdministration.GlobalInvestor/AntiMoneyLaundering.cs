using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.AmlBlocks;
using FundAdministration.GlobalInvestor.Party.AmlDocuments;
using FundAdministration.GlobalInvestor.Party.AmlMonitorBlocks;

namespace FundAdministration.GlobalInvestor;

public class AntiMoneyLaundering : IAntiMoneyLaundering
{
    private readonly HttpClient _httpClient;

    public AntiMoneyLaundering(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAmlBlocksService AmlBlocksService => new AmlBlocksService(_httpClient);

    public IAmlDocumentsService AmlDocumentsService => new AmlDocumentsService(_httpClient);

    public IAmlMonitorBlocksService AmlMonitorBlocksService => new AmlMonitorBlocksService(_httpClient);
}
