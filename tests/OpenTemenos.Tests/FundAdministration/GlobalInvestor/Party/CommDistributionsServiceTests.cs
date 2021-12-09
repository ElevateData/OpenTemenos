using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.CommDistributions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class CommDistributionsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommDistributionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .PostcommdistributionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommDistributionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .PostcommdistributionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentDistributionCommissionService
            .PutcommdistributionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentDistributionCommissionService
            .DeletecommdistributionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCommDistributionsByInternalIdAsync()
    {
        var result = _client.TransferAgentDistributionCommissionService
            .GetcommdistributionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
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
            .PutcommdistributionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommDistributionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentDistributionCommissionService
            .DeletecommdistributionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}