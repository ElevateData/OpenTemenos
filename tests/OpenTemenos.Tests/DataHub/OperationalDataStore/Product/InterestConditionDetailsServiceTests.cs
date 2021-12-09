using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class InterestConditionDetailsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    public void GetInterestConditionsAsync()
    {
        var result = _client.ProductInterestConditionService.GetInterestConditionsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}