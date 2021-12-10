using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.SecurityPrices;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class SecurityPriceServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityPriceAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.SecurityPriceService.CreateSecurityPriceAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}