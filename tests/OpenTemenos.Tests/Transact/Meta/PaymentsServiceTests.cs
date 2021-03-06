using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass, TestCategory("Transact")]
public class PaymentServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetQueryFiltersAsync()
    {
        var result = _client.PaymentService.GetQueryFiltersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}