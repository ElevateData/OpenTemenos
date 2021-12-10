using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ContactHistory;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ContactHistoryServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostContactHistoryByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ContactHistoryService
            .PostcontacthistoryByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostContactHistoryAsync()
    {
        var payload = new _0Payload();
        var result = _client.ContactHistoryService.PostcontacthistoryAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutContactHistoryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ContactHistoryService.PutcontacthistoryAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteContactHistoryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ContactHistoryService.DeletecontacthistoryAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetContactHistoryByInternalIdAsync()
    {
        var result = _client.ContactHistoryService
            .GetcontacthistoryByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutContactHistoryByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ContactHistoryService
            .PutcontacthistoryByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteContactHistoryByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ContactHistoryService
            .DeletecontacthistoryByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}