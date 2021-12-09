using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.FixedMbsIpb;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FixedMbsIpbServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateFixedMbsOrIpbAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedMortgageBackedSecurityOrInflationProtectedBondService
            .CreateFixedMbsOrIpbAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}