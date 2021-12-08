﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class SecurityInstrumentsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetActiveIPOsAsync()
    {
        var result = _client.SecurityInstrumentService.GetActiveIPOsAsync(null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
    [TestMethod]
    public void GetInstrumentsBondsAsync()
    {
        var result = _client.SecurityInstrumentService
            .GetInstrumentsBondsAsync(null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
    [TestMethod]
    public void GetFutureContractsAsync()
    {
        var result = _client.SecurityInstrumentService.GetFutureContractsAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
    [TestMethod]
    public void GetOptionContractsAsync()
    {
        var result = _client.SecurityInstrumentService.GetOptionContractsAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}