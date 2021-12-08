using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.SecurityPrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class SecurityPriceServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void CreateSecurityPriceAsync()
    {
        var body = new _0BULKPayload() { };
        var result = _client.SecurityPriceService.CreateSecurityPriceAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}