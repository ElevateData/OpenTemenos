using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
public class ExternalUserDetailsServiceTests : CredentialManagement
{
    private const string RecordId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetExternalUserAsync()
    {
        var result = _client.ExternalUserDetailService.GetExternalUserAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetExternalUserPreferencesAsync()
    {
        var result = _client.ExternalUserDetailService.GetExternalUserPreferencesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}