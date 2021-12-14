using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class ExternalUserDetailServiceTests : CredentialManagement
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
        var result = _client.ExternalUserDetailService.GetExternalUserPreferencesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}