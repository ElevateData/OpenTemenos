using Transact;
using Transact.Party.ExternalUsers;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass, TestCategory("Transact")]
public class ExternalUserServiceTests : CredentialManagement
{
    private const string ExternalUserPreferencesId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetExternalUserProfileAsync()
    {
        var result = _client.ExternalUserService.GetExternalUserProfileAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetExternalUserPreferencesAsync()
    {
        var result = _client.ExternalUserService.GetExternalUserPreferencesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateExternalUserStatusAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUserStatus();
        var result = _client.ExternalUserService.UpdateExternalUserStatusAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateExternalUserPreferenceAsync()
    {
        var externalUserPreferencesId = string.Empty;
        var payload = new ExternalUserPreference();
        var result = _client.ExternalUserService.CreateExternalUserPreferenceAsync(externalUserPreferencesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateExternalUserPreferenceAsync()
    {
        var externalUserPreferencesId = string.Empty;
        var payload = new ExternalUserPreference();
        var result = _client.ExternalUserService.UpdateExternalUserPreferenceAsync(externalUserPreferencesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteExternalUserPreferenceAsync()
    {
        var externalUserPreferencesId = string.Empty;
        var payload = new ExternalUserPreferenceDelete();
        var result = _client.ExternalUserService.DeleteExternalUserPreferenceAsync(externalUserPreferencesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetExternalUserPreferenceAsync()
    {
        var result = _client.ExternalUserService.GetExternalUserPreferenceAsync(ExternalUserPreferencesId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}