﻿using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class PortfolioAccountsServiceTests : CredentialManagement
{
    private const string PortfolioId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPortfolioAccountsAsync()
    {
        var result = _client.PortfolioAccountsService
            .GetPortfolioAccountsAsync(PortfolioId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}