using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Addresses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AddressesServiceTests : CredentialManagement
{
    private const string InternalId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostAddressesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AddressService.PostAddressesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAddressesAsync()
    {
        var payload = new _0Payload();
        var result = _client.AddressService.PostAddressesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AddressService.PutAddressesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AddressService.DeleteAddressesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAddressesByInternalIdAsync()
    {
        var result = _client.AddressService
            .GetAddressesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AddressService.PutAddressesByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AddressService.DeleteAddressesByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}