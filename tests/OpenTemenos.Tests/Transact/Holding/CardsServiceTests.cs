using Transact;
using Transact.Holding.Cards;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CardsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCardIssuesAsync()
    {
        var result = _client.AccountCardService.GetCardIssuesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCardIssueAsync()
    {
        var cardIssueId = string.Empty;
        var payload = new CardIssue();
        var result = _client.AccountCardService.CreateCardIssueAsync(cardIssueId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCardIssueAsync()
    {
        var cardIssueId = string.Empty;
        var payload = new CardIssue();
        var result = _client.AccountCardService.UpdateCardIssueAsync(cardIssueId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCardIssueAsync()
    {
        var cardIssueId = string.Empty;
        var payload = new CardIssueDelete();
        var result = _client.AccountCardService.DeleteCardIssueAsync(cardIssueId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}