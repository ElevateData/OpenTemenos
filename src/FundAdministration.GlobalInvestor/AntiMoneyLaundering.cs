﻿using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.AmlBlocks;
using FundAdministration.GlobalInvestor.Party.AmlDocuments;
using FundAdministration.GlobalInvestor.Party.AmlMonitorBlocks;

namespace FundAdministration.GlobalInvestor;

public class AntiMoneyLaundering : IAntiMoneyLaundering
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public AntiMoneyLaundering(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAmlBlocksService AmlBlocksService => new AmlBlocksService(_httpClient){BaseUrl = BaseUrl};

    public IAmlDocumentsService AmlDocumentsService => new AmlDocumentsService(_httpClient){BaseUrl = BaseUrl};

    public IAmlMonitorBlocksService AmlMonitorBlocksService => new AmlMonitorBlocksService(_httpClient){BaseUrl = BaseUrl};
}
