using Transact;
using Transact.Holding.CreateNonDeliverableForwards;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CreateNonDeliverableForwardsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateNonDeliverableForwardsAsync()
    {
        var payload = new NonDeliverableForwards();
        var result = _client.CreateNonDeliverableForwardService
            .CreateNonDeliverableForwardsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}