using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class PortfoliosServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetPortfoliosAsync()
    {
        var result = _client.PortfolioDetailService.GetPortfoliosAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}