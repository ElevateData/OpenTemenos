﻿using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AllCustomerProductBalancesServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetAllCustomerProductBalancesAsync()
    {
        var result = _client.CustomerProductBalanceService
            .GetAllCustomerProductBalancesAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}