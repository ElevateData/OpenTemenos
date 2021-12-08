﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class USIndustrylistServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUSIndustrylistAsync()
    {
        var result = _client.UsModelBankUsIndustryClassificationService.GetUSIndustrylistAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}