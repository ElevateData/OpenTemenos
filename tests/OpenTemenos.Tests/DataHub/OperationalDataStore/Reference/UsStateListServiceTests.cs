﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class UsStateListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsStateListAsync()
    {
        var result = _client.UsModelBankUsStateService.GetUsStateListAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}