using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.InitialSubscriptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class InitialSubscriptionsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostInitialSubscriptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService.PostInitialsubscriptionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostInitialSubscriptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService.PostInitialsubscriptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutInitialSubscriptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InitialSubscriptionService.PutInitialsubscriptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteInitialSubscriptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InitialSubscriptionService.DeleteInitialsubscriptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetInitialSubscriptionsByInternalIdAsync()
    {
        var result = _client.InitialSubscriptionService.GetInitialsubscriptionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutInitialSubscriptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService.PutInitialsubscriptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteInitialSubscriptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InitialSubscriptionService.DeleteInitialsubscriptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}