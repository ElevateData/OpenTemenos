using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AgentExceptionCutoffTimes;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class AgentExceptionCutoffTimeServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentExceptionCutOffTimesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionCutoffPerDistributorService
            .PostAgentExceptioncutOffTimesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}