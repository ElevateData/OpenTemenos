using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AgentDistributions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class AgentDistributionServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HierarchyTreeForAgentDistributionService
            .PostAgentDistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}