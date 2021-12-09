using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchangeRepayment;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class ForwardForeignExchangeRepaymentServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateForwardForeignExchangeRepaymentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForwardForeignExchangeRepaymentService.CreateForwardForeignExchangeRepaymentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}