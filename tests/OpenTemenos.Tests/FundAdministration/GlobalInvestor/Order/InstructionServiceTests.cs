using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.Instruction;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class InstructionServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostInstructionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InstructionService.PostInstructionAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}