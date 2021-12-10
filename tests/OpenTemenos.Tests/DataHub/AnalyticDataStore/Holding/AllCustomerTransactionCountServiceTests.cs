﻿using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AllCustomerTransactionCountServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetAllCustomerTransactionCountAsync()
    {
        var result = _client.CustomerTransactionClassificationService.GetAllCustomerTransactionCountAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}