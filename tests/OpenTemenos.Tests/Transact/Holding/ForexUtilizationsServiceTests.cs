﻿using Transact;
using Transact.Holding.ForexUtilizations;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class ForexUtilizationServiceTests : CredentialManagement
{
    private const string UtilizationId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUtilizationsAsync()
    {
        var result = _client.ForexUtilizationService.GetUtilisationsAsync(UtilizationId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void AddUtilisationsAsync()
    {
        var utilisationId = string.Empty;
        var payload = new Utilisations();
        var result = _client.ForexUtilizationService
            .AddUtilisationsAsync(utilisationId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void ApproveUtilisationsAsync()
    {
        var result = _client.ForexUtilizationService.ApproveUtilisationsAsync(UtilizationId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetFxUtilisationRatesAsync()
    {
        var result = _client.ForexUtilizationService.GetFxUtilisationRatesAsync(null, null, null, null, null, null,
                null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}