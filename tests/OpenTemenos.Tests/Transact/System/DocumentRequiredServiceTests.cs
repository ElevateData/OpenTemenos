using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class DocumentRequiredServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetRequiredDocumentsSettingsAsync()
    {
        var result = _client.DocumentRequiredService.GetRequiredDocumentsSettingsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}