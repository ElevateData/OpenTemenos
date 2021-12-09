using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class InterestCatalogServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string RecordId = "";

    [TestMethod]
    public void GetInterestCatalogAsync()
    {
        var result = _client.InterestCatalogService.GetInterestCatalogAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }
}