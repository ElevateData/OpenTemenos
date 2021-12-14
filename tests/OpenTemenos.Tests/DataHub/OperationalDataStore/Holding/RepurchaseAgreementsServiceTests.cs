using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class RepurchaseAgreementServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetREPOPositionMovementsAsync()
    {
        var result = _client.RepurchaseAgreementService.GetREPOPositionMovementsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetRESOPositionMovementsAsync()
    {
        var result = _client.RepurchaseAgreementService.GetRESOPositionMovementsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetRESOPositionAsync()
    {
        var result = _client.RepurchaseAgreementService.GetRESOPositionAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetREPOPositionAsync()
    {
        var result = _client.RepurchaseAgreementService.GetREPOPositionAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}