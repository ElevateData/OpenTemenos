using Transact;
using Transact.Meta.Screens;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class ScreensServiceTests : CredentialManagement
{
    private const string ScreenId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetScreensAsync()
    {
        var result = _client.ScreenService.GetScreensAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetScreenAsync()
    {
        var result = _client.ScreenService.GetScreenAsync(ScreenId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateScreenAsync()
    {
        var screenId = string.Empty;
        var payload = new CreateScreen();
        var result = _client.ScreenService.CreateScreenAsync(screenId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}