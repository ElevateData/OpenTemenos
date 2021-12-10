using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.InitialSubscriptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class InitialSubscriptionsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostInitialSubscriptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService
            .PostInitialsubscriptionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostInitialSubscriptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService
            .PostInitialsubscriptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutInitialSubscriptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InitialSubscriptionService
            .PutInitialsubscriptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteInitialSubscriptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InitialSubscriptionService
            .DeleteInitialsubscriptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetInitialSubscriptionsByInternalIdAsync()
    {
        var result = _client.InitialSubscriptionService
            .GetInitialsubscriptionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutInitialSubscriptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService
            .PutInitialsubscriptionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteInitialSubscriptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService
            .DeleteInitialsubscriptionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}