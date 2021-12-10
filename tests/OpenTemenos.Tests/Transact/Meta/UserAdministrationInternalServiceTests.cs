using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class UserAdministrationInternalServiceTests : CredentialManagement
{
    private const string UserId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetTokenForUserAsync()
    {
        var result = _client.UserAdministrationInternalService.GetTokenForUserAsync(UserId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}