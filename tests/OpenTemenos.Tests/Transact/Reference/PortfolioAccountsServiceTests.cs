using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class PortfolioAccountServiceTests : CredentialManagement
{
    private const string PortfolioId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPortfolioAccountsAsync()
    {
        var result = _client.PortfolioAccountService
            .GetPortfolioAccountsAsync(PortfolioId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}