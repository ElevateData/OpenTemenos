using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class NationalIdsServiceTests : CredentialManagement
{
    private const string LeiId = "";
    private const string NationalIdRef = "US";
    private const string BicId = "";
    private const string ParticipantId = "1";
    private const string CountryId = "US";
    private const string CurrencyCode = "USD";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetBICFromLEIAsync()
    {
        var result = _client.NationalIdsService.GetBICFromLEIAsync(LeiId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBICsFromNationalIdAsync()
    {
        var result = _client.NationalIdsService
            .GetBICsFromNationalIdAsync(NationalIdRef, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetNationalIdDetailsAsync()
    {
        var result = _client.NationalIdsService
            .GetNationalIdDetailsAsync(NationalIdRef, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetNationalIdsFromBicAsync()
    {
        var result = _client.NationalIdsService.GetNationalIdsFromBicAsync(BicId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void ValidateNationalIdAsync()
    {
        var result = _client.NationalIdsService
            .ValidateNationalIdAsync(NationalIdRef, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetParticipantDetailsAsync()
    {
        var result = _client.NationalIdsService.GetParticipantDetailsAsync(ParticipantId, CountryId, CurrencyCode, null,
            null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}