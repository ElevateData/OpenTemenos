﻿using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class IBANCountriesListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetIBANBankDetailsAsync()
    {
        var result = _client.IbanStructureDetailService.GetIBANCountriesListAsync(_recordId, null).Result;
        Assert.IsNotNull(result.Data);
    }
}