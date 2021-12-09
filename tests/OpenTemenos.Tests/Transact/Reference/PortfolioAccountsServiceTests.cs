using System.Linq;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class PortfolioAccountsServiceTests : CredentialManagement
{
    private const string PortfolioId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetPortfolioAccountsAsync()
    {
        var result = _client.PortfolioAccountsService
            .GetPortfolioAccountsAsync(PortfolioId, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}