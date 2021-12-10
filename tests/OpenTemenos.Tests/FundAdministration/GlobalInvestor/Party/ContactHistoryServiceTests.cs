using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ContactHistories;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
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
            .PostcontacthistoryByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostContactHistoryAsync()
    {
        var payload = new _0Payload();
        var result = _client.ContactHistoryService.PostcontacthistoryAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutContactHistoryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ContactHistoryService.PutcontacthistoryAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteContactHistoryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ContactHistoryService.DeletecontacthistoryAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetContactHistoryByInternalIdAsync()
    {
        var result = _client.ContactHistoryService
            .GetcontacthistoryByInternalIdAsync(InternalId)
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
            .PutcontacthistoryByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteContactHistoryByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ContactHistoryService
            .DeletecontacthistoryByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}