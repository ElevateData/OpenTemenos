using System.Linq;
using Transact;
using Transact.Reference.Dates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class DatesServiceTests : CredentialManagement
{
    private const string CompanyIdPath = "US0010001";
    private const string HolidayId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetDatesAsync()
    {
        var result = _client.DatesService
            .GetDatesAsync(null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDatesByCompanyAsync()
    {
        var result = _client.DatesService
            .GetDatesByCompanyAsync(CompanyIdPath, null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHolidayAsync()
    {
        var result = _client.DatesService.GetHolidayAsync(HolidayId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DatesService.CreateHolidayAsync(holidayId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DatesService.UpdateHolidayAsync(holidayId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}