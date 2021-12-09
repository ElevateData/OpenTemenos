using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.CentralRegisters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class CentralRegistersServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostBankAccountsByParentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CentralRegisterService.PostCentralRegistersAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}