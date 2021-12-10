﻿using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class CategoriesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCategoriesAsync()
    {
        var result = _client.ProductInternalCategoryCodeService.GetCategoriesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}