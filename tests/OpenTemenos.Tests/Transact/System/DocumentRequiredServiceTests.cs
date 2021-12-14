using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
[TestCategory("Transact")]
public class DocumentRequiredServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetRequiredDocumentsSettingsAsync()
    {
        var result = _client.DocumentRequiredService.GetRequiredDocumentsSettingsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}