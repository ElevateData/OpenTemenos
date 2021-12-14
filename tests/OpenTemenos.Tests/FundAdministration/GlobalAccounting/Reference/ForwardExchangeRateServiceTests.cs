using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ForwardExchangeRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class ForwardExchangeRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateForwardExchangeRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.ForwardExchangeRateService
            .CreateForwardExchangeRateAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}