using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
[TestCategory("Transact")]
public class BICServiceTests : CredentialManagement
{
    private const string BicId = "AEIBCHGV";
    private const string CountryCode = "CH";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBICStatusAsync()
    {
        var result = _client.BICService.GetBICStatusAsync(BicId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void ValidateBICAsync()
    {
        var result = _client.BICService.ValidateBICAsync(BicId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetLEIFromBICAsync()
    {
        var result = _client.BICService.GetLEIFromBICAsync(BicId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBICIdentifierAsync()
    {
        var result = _client.BICService
            .GetBICIdentifierAsync(CountryCode).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}