﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BeneficiariesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUtilityBeneficiariesAsync()
    {
        var result = _client.BeneficiariesService.GetUtilityBeneficiariesAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}