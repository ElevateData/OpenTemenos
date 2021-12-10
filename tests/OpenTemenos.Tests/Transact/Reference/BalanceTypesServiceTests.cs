using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BalanceTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBalanceTypesAsync()
    {
        var result = _client.BalanceTypesService.GetBalanceTypesAsync().Result;
        Assert.IsNotNull(result.Body);
    }
}