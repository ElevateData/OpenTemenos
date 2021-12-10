using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.ForwardExchangeRate;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class ForwardExchangeRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateForwardExchangeRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.ForwardExchangeRateService
            .CreateForwardExchangeRateAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}