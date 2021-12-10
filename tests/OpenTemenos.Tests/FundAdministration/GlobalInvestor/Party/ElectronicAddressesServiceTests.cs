using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ElectronicAddresses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ElectronicAddressesServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostElectronicAddressesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService
            .PostElectronicAddressesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostElectronicAddressesAsync()
    {
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService
            .PostElectronicAddressesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutElectronicAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ElectronicAddressService.PutElectronicAddressesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteElectronicAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ElectronicAddressService
            .DeleteElectronicAddressesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetElectronicAddressesByInternalIdAsync()
    {
        var result = _client.ElectronicAddressService
            .GetElectronicAddressesByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutElectronicAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService
            .PutElectronicAddressesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteElectronicAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService
            .DeleteElectronicAddressesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}