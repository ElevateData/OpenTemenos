﻿using Transact.Holding;
using Transact.Holding.UsDashboards;
using Transact.Holding.UsSafeDeposits;

namespace Transact;

public class UsModelBank : IUsModelBank
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public UsModelBank(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IUsDashboardsService HoldingSummaryService => new UsDashboardsService(_httpClient) { BaseUrl = BaseUrl };

    public IUsSafeDepositsService SafeDepositService => new UsSafeDepositsService(_httpClient) { BaseUrl = BaseUrl };
}
