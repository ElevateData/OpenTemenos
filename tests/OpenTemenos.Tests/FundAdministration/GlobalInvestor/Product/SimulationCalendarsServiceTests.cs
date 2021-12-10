using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.SimulationCalendars;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class SimulationCalendarServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSimulationCalendarsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SimulationCalendarService
            .PostSimulationcalendarsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSimulationCalendarsAsync()
    {
        var payload = new _0Payload();
        var result = _client.SimulationCalendarService
            .PostSimulationcalendarsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSimulationCalendarsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SimulationCalendarService
            .PutSimulationcalendarsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSimulationCalendarsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SimulationCalendarService
            .DeleteSimulationcalendarsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSimulationCalendarsByInternalIdAsync()
    {
        var result = _client.SimulationCalendarService
            .GetSimulationcalendarsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSimulationCalendarsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SimulationCalendarService
            .PutSimulationcalendarsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSimulationCalendarsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SimulationCalendarService
            .DeleteSimulationcalendarsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}