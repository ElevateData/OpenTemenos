﻿using Transact;
using Transact.Reference.Currencies;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CurrenciesServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private const string CurrencyMarketId = "";
    private const string NumericCurrencyCode = "";
    private const string Year = "2020";
    private const string Rank = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCurrenciesAsync()
    {
        var result = _client.CurrenciesService
            .GetCurrenciesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCurrencyInfoAsync()
    {
        var result = _client.CurrenciesService.GetCurrencyInfoAsync(CurrencyId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCurrencyInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyInfo();
        var result = _client.CurrenciesService
            .CreateCurrencyInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCurrencyInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyInfo();
        var result = _client.CurrenciesService
            .UpdateCurrencyInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCurrencyInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyInfoDelete();
        var result = _client.CurrenciesService
            .DeleteCurrencyInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCurrencyMarketAsync()
    {
        var result = _client.CurrenciesService.GetCurrencyMarketAsync(CurrencyMarketId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCurrencyMarketAsync()
    {
        var currencyMarketId = string.Empty;
        var payload = new CurrencyMarket();
        var result = _client.CurrenciesService
            .CreateCurrencyMarketAsync(currencyMarketId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCurrencyMarketAsync()
    {
        var currencyMarketId = string.Empty;
        var payload = new CurrencyMarket();
        var result = _client.CurrenciesService
            .UpdateCurrencyMarketAsync(currencyMarketId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCurrencyFromNumericCodeAsync()
    {
        var result = _client.CurrenciesService
            .GetCurrencyFromNumericCodeAsync(NumericCurrencyCode)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCurrencyModificationsAsync()
    {
        var result = _client.CurrenciesService
            .GetCurrencyModificationsAsync(CurrencyId, Year).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCurrencyForRankAsync()
    {
        var result = _client.CurrenciesService
            .GetCurrencyForRankAsync(Rank).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCurrencyBasicInfoAsync()
    {
        var result = _client.CurrenciesService.GetCurrencyBasicInfoAsync(CurrencyId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCurrencyBasicInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyBasicInfo();
        var result = _client.CurrenciesService
            .CreateCurrencyBasicInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCurrencyBasicInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyBasicInfo();
        var result = _client.CurrenciesService
            .UpdateCurrencyBasicInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCurrencyBasicInfoAsync()
    {
        var currencyId = string.Empty;
        var payload = new CurrencyBasicInfoDelete();
        var result = _client.CurrenciesService
            .DeleteCurrencyBasicInfoAsync(currencyId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}