﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class IBANBankDetailsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetIBANBankDetailsAsync()
    {
        var result = _client.IbanDetailService.GetIBANBankDetailsAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}