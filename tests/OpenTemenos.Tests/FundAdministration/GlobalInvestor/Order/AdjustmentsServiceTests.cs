using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Adjustments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class AdjustmentServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAdjustmentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.UnderlyingRegAdjustmentService.PostadjustmentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}