using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Instructions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class InstructionServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostInstructionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InstructionService.PostInstructionAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}