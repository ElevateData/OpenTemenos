using Transact;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass, TestCategory("Transact")]
public class CustomerServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string InterestCatalogId = "1";
    private const string PeriodicInterestId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetExternalUserAsync()
    {
        var result = _client.CustomerService.GetEligibleProductsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPeriodicInterestsAsync()
    {
        var result = _client.CustomerService.GetPeriodicInterestsAsync(PeriodicInterestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetInterestCatalogAsync()
    {
        var result = _client.CustomerService.GetInterestCatalogAsync(InterestCatalogId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}