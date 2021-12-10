﻿using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CustomersServiceTests : CredentialManagement
{
    private const string AccountId = "";
    private const string ArrangementId = "";
    private const string CustomerId = "100282";
    private const string PortfolioId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetArrangementsForCustomerAsync()
    {
        var result = _client.CustomerHoldingService
            .GetArrangementsForCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetArrangementForCustomerAsync()
    {
        var result = _client.CustomerHoldingService.GetArrangementForCustomerAsync(CustomerId, ArrangementId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAccountForCustomerAsync()
    {
        var result = _client.CustomerHoldingService
            .GetAccountForCustomerAsync(CustomerId, AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetOverdueSettlementsByCustomerAsync()
    {
        var result = _client.CustomerHoldingService.GetOverdueSettlementsByCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAccountTransactionsForCustomerAsync()
    {
        var result = _client.CustomerHoldingService.GetAccountTransactionsForCustomerAsync(CustomerId, AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetOutstandingSettlementsAsync()
    {
        var result = _client.CustomerHoldingService.GetOutstandingSettlementsAsync(CustomerId, PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAccountsForCustomerAsync()
    {
        var result = _client.CustomerHoldingService
            .GetAccountsForCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}