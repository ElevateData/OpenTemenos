using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FixedCalendars;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FixedCalendarServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFixedCalendarsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FixedCalendarService.PostFixedcalendarsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFixedCalendarsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FixedCalendarService.PostFixedcalendarsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFixedCalendarsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedCalendarService.PutFixedcalendarsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFixedCalendarsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedCalendarService.DeleteFixedcalendarsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFixedCalendarsByInternalIdAsync()
    {
        var result = _client.FixedCalendarService
            .GetFixedcalendarsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFixedCalendarsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FixedCalendarService
            .PutFixedcalendarsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFixedCalendarsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FixedCalendarService
            .DeleteFixedcalendarsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}