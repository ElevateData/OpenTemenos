using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FixedCalendars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FixedCalendarsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostFixedCalendarsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FixedCalendarService.PostFixedcalendarsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostFixedCalendarsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FixedCalendarService.PostFixedcalendarsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFixedCalendarsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedCalendarService.PutFixedcalendarsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFixedCalendarsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedCalendarService.DeleteFixedcalendarsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFixedCalendarsByInternalIdAsync()
    {
        var result = _client.FixedCalendarService.GetFixedcalendarsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFixedCalendarsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FixedCalendarService.PutFixedcalendarsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFixedCalendarsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FixedCalendarService.DeleteFixedcalendarsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}