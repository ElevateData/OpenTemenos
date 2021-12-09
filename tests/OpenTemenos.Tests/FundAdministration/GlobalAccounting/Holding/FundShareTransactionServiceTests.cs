using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.FundShareTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FundShareTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void FundShareTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ShareholderService.FundSharetransactionAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}