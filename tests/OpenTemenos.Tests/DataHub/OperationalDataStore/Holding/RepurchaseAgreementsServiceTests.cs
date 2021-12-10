using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class RepurchaseAgreementsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetREPOPositionMovementsAsync()
    {
        var result = _client.RepurchaseAgreementService.GetREPOPositionMovementsAsync(null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetRESOPositionMovementsAsync()
    {
        var result = _client.RepurchaseAgreementService.GetRESOPositionMovementsAsync(null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetRESOPositionAsync()
    {
        var result = _client.RepurchaseAgreementService.GetRESOPositionAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetREPOPositionAsync()
    {
        var result = _client.RepurchaseAgreementService.GetREPOPositionAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}