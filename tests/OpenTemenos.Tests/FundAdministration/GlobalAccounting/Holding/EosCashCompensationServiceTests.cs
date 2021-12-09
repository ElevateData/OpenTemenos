using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.EosCashCompensation;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class EosCashCompensationServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.NewSecurityWithCashCompensationService
            .CreateExchangeOfSecurityForCashCompensationAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}