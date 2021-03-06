using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class ProductServiceTests : CredentialManagement
{
    private const string RuleId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPeriodicRuleAsync()
    {
        var result = _client.ProductService.GetPeriodicRuleAsync(RuleId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}