using Transact;
using Transact.Reference.Countries;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class CountryServiceTests : CredentialManagement
{
    private const string CountryId = "US";
    private const string GroupId = "EEA";
    private const string RegionId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCountriesAsync()
    {
        var result = _client.CountryService.GetCountriesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCountryCodesAsync()
    {
        var result = _client.CountryService
            .GetCountryCodesAsync(CountryId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCountryDetailsAsync()
    {
        var result = _client.CountryService.GetCountryDetailsAsync(CountryId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCountryDetailsAsync()
    {
        var countryId = string.Empty;
        var payload = new CountryDetails();
        var result = _client.CountryService
            .CreateCountryDetailsAsync(countryId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCountryDetailsAsync()
    {
        var countryId = string.Empty;
        var payload = new CountryDetails();
        var result = _client.CountryService
            .UpdateCountryDetailsAsync(countryId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCountryGroupAsync()
    {
        var result = _client.CountryService.GetCountryGroupAsync(GroupId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCountryGroupAsync()
    {
        var groupId = string.Empty;
        var payload = new CountryGroup();
        var result = _client.CountryService.CreateCountryGroupAsync(groupId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCountryGroupAsync()
    {
        var groupId = string.Empty;
        var payload = new CountryGroup();
        var result = _client.CountryService.UpdateCountryGroupAsync(groupId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCountryGroupAsync()
    {
        var groupId = string.Empty;
        var payload = new CountryGroupDelete();
        var result = _client.CountryService.DeleteCountryGroupAsync(groupId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCountryGroupListAsync()
    {
        var result = _client.CountryService
            .GetCountryGroupListAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCountryRegionAsync()
    {
        var result = _client.CountryService.GetCountryRegionAsync(RegionId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCountryRegionAsync()
    {
        var regionId = string.Empty;
        var payload = new CountryRegion();
        var result = _client.CountryService.CreateCountryRegionAsync(regionId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCountryRegionAsync()
    {
        var regionId = string.Empty;
        var payload = new CountryRegion();
        var result = _client.CountryService.UpdateCountryRegionAsync(regionId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}