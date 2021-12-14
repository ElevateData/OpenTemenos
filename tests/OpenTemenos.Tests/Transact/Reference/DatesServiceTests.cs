using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Reference.Dates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
[TestCategory("Transact")]
public class DateServiceTests : CredentialManagement
{
    private const string CompanyIdPath = "US0010001";
    private const string HolidayId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetDatesAsync()
    {
        var result = _client.DateService
            .GetDatesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetDatesByCompanyAsync()
    {
        var result = _client.DateService
            .GetDatesByCompanyAsync(CompanyIdPath)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHolidayAsync()
    {
        var result = _client.DateService.GetHolidayAsync(HolidayId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DateService.CreateHolidayAsync(holidayId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DateService.UpdateHolidayAsync(holidayId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}