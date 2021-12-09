using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.EosNewSecurityWithoutCash;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class EosNewSecurityWithoutCashServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.NewSecurityWithoutCashCompensationService
            .CreateExchangeOfNewSecurityWithOutCashAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}