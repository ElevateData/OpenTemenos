using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Reference.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

[TestClass]
public class MessagesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void PostCmessAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.MessageService.PostCmessAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}