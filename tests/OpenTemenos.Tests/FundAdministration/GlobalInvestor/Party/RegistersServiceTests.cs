using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Registers;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class RegisterServiceTests : CredentialManagement
{
    private const string RegisterId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetRegisterAsync()
    {
        var result = _client.InvestorAccountService
            .GetRegisterAsync().Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostRegisterAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorAccountService.PostRegisterAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutRegisterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorAccountService.PutRegisterAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRegisterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorAccountService.DeleteRegisterAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetRegisterByRegisterIdAsync()
    {
        var result = _client.InvestorAccountService
            .GetRegisterByRegisterIdAsync(RegisterId)
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
            .PutRegisterByRegisterIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRegisterByRegisterIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorAccountService
            .DeleteRegisterByRegisterIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}