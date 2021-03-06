using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class ChequeTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetChequeTypesAsync()
    {
        var result = _client.ChequeTypeService
            .GetChequeTypesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}