using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.ForwardInterestRate;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
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