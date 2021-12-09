﻿using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BICsServiceTests : CredentialManagement
{
    private const string BicId = "";
    private const string CountryCode = "US";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBICStatusAsync()
    {
        var result = _client.BICsService.GetBICStatusAsync(BicId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void ValidateBICAsync()
    {
        var result = _client.BICsService.ValidateBICAsync(BicId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetLEIFromBICAsync()
    {
        var result = _client.BICsService.GetLEIFromBICAsync(BicId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBICIdentifierAsync()
    {
        var result = _client.BICsService
            .GetBICIdentifierAsync(CountryCode, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}