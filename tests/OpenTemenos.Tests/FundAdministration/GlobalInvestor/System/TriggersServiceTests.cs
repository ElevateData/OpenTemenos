using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.System.Triggers;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.System;

[TestClass]
public class TriggersServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTriggersAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.OutboundTriggerService.PosttriggersAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}