using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.ExchangeRate;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class ExchangeRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateExchangeRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.ExchangeRateService.CreateExchangeRateAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}