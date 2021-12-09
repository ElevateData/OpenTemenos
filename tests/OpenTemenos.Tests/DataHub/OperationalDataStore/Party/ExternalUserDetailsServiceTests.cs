using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
public class ExternalUserDetailsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string RecordId = "";

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