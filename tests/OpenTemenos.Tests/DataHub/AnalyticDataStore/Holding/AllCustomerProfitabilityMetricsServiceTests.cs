using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AllCustomerProfitabilityMetricsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetAllCustomerProfitabilityMetricsAsync()
    {
        var result = _client.CustomerProfitabilityService.GetAllCustomerProfitabilityMetricsAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}