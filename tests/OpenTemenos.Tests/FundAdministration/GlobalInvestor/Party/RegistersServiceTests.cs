using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Registers;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class RegistersServiceTests : CredentialManagement
{
    private const string RegisterId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetRegisterAsync()
    {
        var result = _client.InvestorAccountService
            .GetRegisterAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostRegisterAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorAccountService.PostRegisterAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutRegisterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorAccountService.PutRegisterAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRegisterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorAccountService.DeleteRegisterAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetRegisterByRegisterIdAsync()
    {
        var result = _client.InvestorAccountService
            .GetRegisterByRegisterIdAsync(null, null, null, null, null, null, null, null, null, null, RegisterId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutRegisterByRegisterIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorAccountService
            .PutRegisterByRegisterIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRegisterByRegisterIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorAccountService
            .DeleteRegisterByRegisterIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}