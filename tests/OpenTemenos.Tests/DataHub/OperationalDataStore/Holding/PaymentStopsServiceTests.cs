using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class PaymentStopsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetPaymentStopsAsync()
    {
        var result = _client.PaymentStopService.GetPaymentStopsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}