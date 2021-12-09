using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

//TODO: the documented URL is pointed to localhost:8080. Figure out the correct base url
[TestClass]
public class CountryHolidaysServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetCountryHolidaysAsync()
    {
        var result = _client.CountryHolidayService.GetCountryholidaysAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}