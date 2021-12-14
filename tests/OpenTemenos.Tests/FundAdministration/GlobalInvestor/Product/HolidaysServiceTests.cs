using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.Holidays;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class HolidayServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostHolidaysByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.HolidayService.PostHolidaysByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostHolidaysAsync()
    {
        var payload = new _0Payload();
        var result = _client.HolidayService.PostHolidaysAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutHolidaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HolidayService.PutHolidaysAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteHolidaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HolidayService.DeleteHolidaysAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHolidaysByInternalIdAsync()
    {
        var result = _client.HolidayService
            .GetHolidaysByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutHolidaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HolidayService.PutHolidaysByIdAsync(internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteHolidaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HolidayService.DeleteHolidaysByIdAsync(internalId, payload: payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}