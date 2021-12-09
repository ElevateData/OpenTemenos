using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class PaymentStopsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetPaymentStopsAsync()
    {
        var result = _client.PaymentStopService.GetPaymentStopsAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}