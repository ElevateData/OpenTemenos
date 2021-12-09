using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.ContractChanges;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class ContractChangesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostContractChangesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RegisterContractChangeService
            .PostcontractchangesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}