using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;
using Transact.Reference.Dates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class DatesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string CompanyIdPath = "";
    private const string HolidayId = "";

    [TestMethod]
    public void GetDatesAsync()
    {
        var result = _client.DatesService.GetDatesAsync(null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CurrentWorkingDate: {result.Body.First().CurrentWorkingDate}");
    }

    [TestMethod]
    public void GetDatesByCompanyAsync()
    {
        var result = _client.DatesService.GetDatesByCompanyAsync(CompanyIdPath, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHolidayAsync()
    {
        var result = _client.DatesService.GetHolidayAsync(HolidayId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DatesService.CreateHolidayAsync(holidayId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdateHolidayAsync()
    {
        var holidayId = string.Empty;
        var payload = new Holiday();
        var result = _client.DatesService.UpdateHolidayAsync(holidayId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}