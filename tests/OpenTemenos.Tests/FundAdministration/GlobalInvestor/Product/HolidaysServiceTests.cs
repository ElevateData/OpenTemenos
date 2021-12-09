using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.Holidays;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class HolidaysServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostHolidaysByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.HolidayService.PostHolidaysByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostHolidaysAsync()
    {
        var payload = new _0Payload();
        var result = _client.HolidayService.PostHolidaysAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutHolidaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HolidayService.PutHolidaysAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteHolidaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HolidayService.DeleteHolidaysAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHolidaysByInternalIdAsync()
    {
        var result = _client.HolidayService
            .GetHolidaysByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutHolidaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HolidayService.PutHolidaysByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteHolidaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HolidayService.DeleteHolidaysByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}