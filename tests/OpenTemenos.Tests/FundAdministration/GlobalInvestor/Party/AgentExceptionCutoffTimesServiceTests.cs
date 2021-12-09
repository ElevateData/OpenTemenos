using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AgentExceptionCutoffTimes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AgentExceptionCutoffTimesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostAgentExceptionCutOffTimesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionCutoffPerDistributorService.PostAgentExceptioncutOffTimesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}