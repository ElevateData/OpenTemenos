using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Order.ContractChanges;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class ContractChangeServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostContractChangesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RegisterContractChangeService
            .PostcontractchangesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}