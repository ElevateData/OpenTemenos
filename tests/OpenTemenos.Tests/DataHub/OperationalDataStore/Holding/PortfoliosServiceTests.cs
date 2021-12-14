using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class PortfolioServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetPortfoliosAsync()
    {
        var result = _client.PortfolioDetailService.GetPortfoliosAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}