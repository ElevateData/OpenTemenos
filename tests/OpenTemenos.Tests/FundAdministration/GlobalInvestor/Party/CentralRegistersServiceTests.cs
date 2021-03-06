using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.CentralRegisters;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class CentralRegisterServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostBankAccountsByParentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CentralRegisterService.PostCentralRegistersAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}