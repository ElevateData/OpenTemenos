using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsFdicClassCodesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetFdicClassCodeAsync()
    {
        var result = _client.UsFdicClassCodesService.GetFdicClassCodeAsync(null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}