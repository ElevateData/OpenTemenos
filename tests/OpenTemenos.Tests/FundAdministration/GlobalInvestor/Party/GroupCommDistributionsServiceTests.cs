using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.GroupCommDistributions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class GroupCommDistributionsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostGroupCommDistributionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentGroupCommissionService
            .PostgroupcommdistributionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostGroupCommDistributionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentGroupCommissionService
            .PostgroupcommdistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutGroupCommDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentGroupCommissionService
            .PutgroupcommdistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteGroupCommDistributionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentGroupCommissionService
            .DeletegroupcommdistributionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetGroupCommDistributionsByInternalIdAsync()
    {
        var result = _client.TransferAgentGroupCommissionService
            .GetgroupcommdistributionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutGroupCommDistributionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentGroupCommissionService
            .PutgroupcommdistributionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteGroupCommDistributionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentGroupCommissionService
            .DeletegroupcommdistributionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}