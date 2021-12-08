﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class DateDetailsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetDatesByCompanyAsync()
    {
        var result = _client.SystemBusinessDateService.GetDatesByCompanyAsync(_recordId, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
    [TestMethod]
    public void GetDatesAsync()
    {
        var result = _client.SystemBusinessDateService.GetDatesAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}