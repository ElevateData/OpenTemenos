using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.PermissionCountries;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class PermissionCountriesServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostPermissionCountriesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .PostPermissionCountriesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostPermissionCountriesAsync()
    {
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .PostPermissionCountriesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutPermissionCountriesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PermissionCountryService.PutPermissionCountriesAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePermissionCountriesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PermissionCountryService
            .DeletePermissionCountriesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPermissionCountriesByInternalIdAsync()
    {
        var result = _client.PermissionCountryService
            .GetPermissionCountriesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutPermissionCountriesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .PutPermissionCountriesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePermissionCountriesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .DeletePermissionCountriesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}