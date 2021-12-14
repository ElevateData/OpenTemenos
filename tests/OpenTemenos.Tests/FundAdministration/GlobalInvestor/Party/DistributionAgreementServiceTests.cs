using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.DistributionAgreements;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class DistributionAgreementServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostDistributionAgreementAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributionAgreementService
            .PostDistributionAgreementAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}