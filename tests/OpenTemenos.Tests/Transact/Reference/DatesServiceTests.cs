using Transact;
using Transact.Reference.Dates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class DatesServiceTests : CredentialManagement
{
    private const string CompanyIdPath = "US0010001";
    private const string HolidayId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetDatesAsync()
    {
        var result = _client.DatesService
            .GetDatesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDatesByCompanyAsync()
    {
        var result = _client.DatesService
            .GetDatesByCompanyAsync(CompanyIdPath)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHolidayAsync()
    {
        var result = _client.DatesService.GetHolidayAsync(HolidayId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DatesService.CreateHolidayAsync(holidayId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DatesService.UpdateHolidayAsync(holidayId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}