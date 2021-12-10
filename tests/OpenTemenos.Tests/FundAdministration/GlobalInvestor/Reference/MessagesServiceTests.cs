using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Reference.Messages;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

//TODO: the documented URL is pointed to localhost:8080. Figure out the correct base url
[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class MessageServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostCmessAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.MessageService.PostCmessAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}