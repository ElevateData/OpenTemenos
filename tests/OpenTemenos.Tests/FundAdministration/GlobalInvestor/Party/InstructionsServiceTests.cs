using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Instructions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class InstructionsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostInstructionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService.PostInstructionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostInstructionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService.PostInstructionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutInstructionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayAllService.PutInstructionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteInstructionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayAllService.DeleteInstructionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetInstructionsByInternalIdAsync()
    {
        var result = _client.ReinvestOrPayAllService.GetInstructionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutInstructionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService.PutInstructionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteInstructionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService.DeleteInstructionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}