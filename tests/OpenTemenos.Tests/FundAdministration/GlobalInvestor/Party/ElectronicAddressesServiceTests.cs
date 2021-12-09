using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ElectronicAddresses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ElectronicAddressesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostElectronicAddressesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService.PostElectronicAddressesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostElectronicAddressesAsync()
    {
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService.PostElectronicAddressesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutElectronicAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ElectronicAddressService.PutElectronicAddressesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteElectronicAddressesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ElectronicAddressService.DeleteElectronicAddressesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetElectronicAddressesByInternalIdAsync()
    {
        var result = _client.ElectronicAddressService.GetElectronicAddressesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutElectronicAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService.PutElectronicAddressesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteElectronicAddressesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ElectronicAddressService.DeleteElectronicAddressesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}