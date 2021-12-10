using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.PermissionCountries;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class PermissionCountryServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostPermissionCountriesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .PostPermissionCountriesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostPermissionCountriesAsync()
    {
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .PostPermissionCountriesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutPermissionCountriesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PermissionCountryService.PutPermissionCountriesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePermissionCountriesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PermissionCountryService
            .DeletePermissionCountriesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPermissionCountriesByInternalIdAsync()
    {
        var result = _client.PermissionCountryService
            .GetPermissionCountriesByInternalIdAsync(
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
            .PutPermissionCountriesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePermissionCountriesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.PermissionCountryService
            .DeletePermissionCountriesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}