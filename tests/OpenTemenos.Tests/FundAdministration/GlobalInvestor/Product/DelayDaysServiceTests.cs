using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.DelayDays;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class DelayDayServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostDelayDaysByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DelayDayService.PostdelaydaysByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostDelayDaysAsync()
    {
        var payload = new _0Payload();
        var result = _client.DelayDayService.PostdelaydaysAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutDelayDaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DelayDayService.PutdelaydaysAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteDelayDaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DelayDayService.DeletedelaydaysAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetDelayDaysByInternalIdAsync()
    {
        var result = _client.DelayDayService
            .GetdelaydaysByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutDelayDaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DelayDayService.PutdelaydaysByIdAsync(internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteDelayDaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DelayDayService.DeletedelaydaysByIdAsync(internalId, payload: payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}