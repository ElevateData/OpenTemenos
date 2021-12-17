﻿using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class RetailDepositProductBalanceServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetRetailDepositProductBalancesAsync()
    {
        var result = _client.RetailDepositProductBalanceService.GetRetailDepositProductBalancesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}