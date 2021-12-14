using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Addresses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class AddressServiceTests : CredentialManagement
{
    private const string InternalId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostAddressesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AddressService.PostAddressesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAddressesAsync()
    {
        var payload = new _0Payload();
        var result = _client.AddressService.PostAddressesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AddressService.PutAddressesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AddressService.DeleteAddressesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAddressesByInternalIdAsync()
    {
        var result = _client.AddressService
            .GetAddressesByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AddressService.PutAddressesByIdAsync(internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AddressService.DeleteAddressesByIdAsync(internalId, payload: payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}