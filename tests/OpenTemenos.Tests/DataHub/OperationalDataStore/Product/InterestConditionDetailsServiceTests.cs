using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class InterestConditionDetailServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetInterestConditionsAsync()
    {
        var result = _client.ProductInterestConditionService.GetInterestConditionsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}