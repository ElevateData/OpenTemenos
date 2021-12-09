using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.DistributionAgreement;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class DistributionAgreementServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void PostDistributionAgreementAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributionAgreementService
            .PostDistributionAgreementAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}