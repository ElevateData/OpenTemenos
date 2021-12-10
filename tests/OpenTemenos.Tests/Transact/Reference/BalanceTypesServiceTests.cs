using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class BalanceTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBalanceTypesAsync()
    {
        var result = _client.BalanceTypeService.GetBalanceTypesAsync().Result;
        Assert.IsNotNull(result.Body);
    }
}