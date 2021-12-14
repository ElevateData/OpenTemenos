using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.CommDistributions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class CommDistributionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommDistributionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .PostcommdistributionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommDistributionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .PostcommdistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentDistributionCommissionService
            .PutcommdistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentDistributionCommissionService
            .DeletecommdistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCommDistributionsByInternalIdAsync()
    {
        var result = _client.TransferAgentDistributionCommissionService
            .GetcommdistributionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommDistributionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .PutcommdistributionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommDistributionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .DeletecommdistributionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}