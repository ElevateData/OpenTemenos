using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Reference.Messages;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

//TODO: the documented URL is pointed to localhost:8080. Figure out the correct base url
[TestClass]
public class MessagesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostCmessAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.MessageService.PostCmessAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}