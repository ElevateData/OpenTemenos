﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class UtilityBeneficiariesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUtilityBeneficiariesAsync()
    {
        var result = _client.UtilityBeneficiaryService.GetUtilityBeneficiariesAsync(null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}