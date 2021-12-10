using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurities;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class EosMultipleSecurityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.MultipleSecurityService
            .CreateExchangeOfSecurityIntoSeveralSecuritiesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}