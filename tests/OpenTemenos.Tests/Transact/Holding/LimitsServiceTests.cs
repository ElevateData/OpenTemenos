using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class LimitsServiceTests : CredentialManagement
{
    private const string ArrangementId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetLimitCashflowAsync()
    {
        var result = _client.LimitLiabilityAndForexLimitService.GetLimitCashflowAsync(ArrangementId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerGroupLimitsAsync()
    {
        var result = _client.LimitLiabilityAndForexLimitService.GetCustomerGroupLimitsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}