using Transact;
using Transact.System.ExternalAccountings;

namespace OpenTemenos.Tests.Transact.System;

[TestClass, TestCategory("Transact")]
public class ExternalAccountingServiceTests : CredentialManagement
{
    private const string SettingId = "1";
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetExternalAccountingSystemSettingsAsync()
    {
        var result = _client.ExternalAccountingService.GetExternalAccountingSystemSettingsAsync(SettingId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateExternalAccountingSystemSettingsAsync()
    {
        var settingId = string.Empty;
        var payload = new ExternalAccountingSystemSettings();
        var result = _client.ExternalAccountingService.CreateExternalAccountingSystemSettingsAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}