using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class GuaranteeDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetGuaranteeIssuanceRequestsAsync()
    {
        var result = _client.GuaranteeDetailService.GetGuaranteeIssuanceRequestsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}