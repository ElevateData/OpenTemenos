using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Instructions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class InstructionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostInstructionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService
            .PostInstructionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostInstructionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService.PostInstructionsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutInstructionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayAllService.PutInstructionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteInstructionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayAllService.DeleteInstructionsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetInstructionsByInternalIdAsync()
    {
        var result = _client.ReinvestOrPayAllService
            .GetInstructionsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutInstructionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService
            .PutInstructionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteInstructionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayAllService
            .DeleteInstructionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}