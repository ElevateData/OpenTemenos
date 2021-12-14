using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class CategoryServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCategoriesAsync()
    {
        var result = _client.ProductInternalCategoryCodeService.GetCategoriesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}