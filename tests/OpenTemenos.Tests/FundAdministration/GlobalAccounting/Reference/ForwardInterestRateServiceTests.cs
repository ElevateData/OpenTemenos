using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.ForwardInterestRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class ForwardInterestRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateForwardInterestRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.ForwardInterestRateService
            .CreateForwardInterestRateAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}