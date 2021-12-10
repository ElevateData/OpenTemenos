using Transact;
using Transact.Reference.Countries;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CountriesServiceTests : CredentialManagement
{
    private const string CountryId = "US";
    private const string GroupId = "EEA";
    private const string RegionId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCountriesAsync()
    {
        var result = _client.CountriesService.GetCountriesAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCountryCodesAsync()
    {
        var result = _client.CountriesService
            .GetCountryCodesAsync(CountryId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCountryDetailsAsync()
    {
        var result = _client.CountriesService.GetCountryDetailsAsync(CountryId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCountryDetailsAsync()
    {
        var countryId = string.Empty;
        var payload = new CountryDetails();
        var result = _client.CountriesService
            .CreateCountryDetailsAsync(countryId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCountryDetailsAsync()
    {
        var countryId = string.Empty;
        var payload = new CountryDetails();
        var result = _client.CountriesService
            .UpdateCountryDetailsAsync(countryId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCountryGroupAsync()
    {
        var result = _client.CountriesService.GetCountryGroupAsync(GroupId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCountryGroupAsync()
    {
        var groupId = string.Empty;
        var payload = new CountryGroup();
        var result = _client.CountriesService.CreateCountryGroupAsync(groupId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCountryGroupAsync()
    {
        var groupId = string.Empty;
        var payload = new CountryGroup();
        var result = _client.CountriesService.UpdateCountryGroupAsync(groupId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCountryGroupAsync()
    {
        var groupId = string.Empty;
        var payload = new CountryGroupDelete();
        var result = _client.CountriesService.DeleteCountryGroupAsync(groupId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCountryGroupListAsync()
    {
        var result = _client.CountriesService
            .GetCountryGroupListAsync(null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCountryRegionAsync()
    {
        var result = _client.CountriesService.GetCountryRegionAsync(RegionId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCountryRegionAsync()
    {
        var regionId = string.Empty;
        var payload = new CountryRegion();
        var result = _client.CountriesService.CreateCountryRegionAsync(regionId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCountryRegionAsync()
    {
        var regionId = string.Empty;
        var payload = new CountryRegion();
        var result = _client.CountriesService.UpdateCountryRegionAsync(regionId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}