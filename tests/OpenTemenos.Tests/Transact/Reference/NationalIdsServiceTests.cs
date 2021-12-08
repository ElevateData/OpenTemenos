using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class NationalIdsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string LeiId = "";
    private const string NationalIdRef = "US";
    private const string BicId = "";
    private const string ParticipantId = "1";
    private const string CountryId = "US";
    private const string CurrencyCode = "USD";

    [TestMethod]
    public void GetBICFromLEIAsync()
    {
        var result = _client.NationalIdsService.GetBICFromLEIAsync(LeiId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"BicId: {result.Body.First().BicId}");
    }

    [TestMethod]
    public void GetBICsFromNationalIdAsync()
    {
        var result = _client.NationalIdsService.GetBICsFromNationalIdAsync(NationalIdRef, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"BicIds: {string.Join(",", result.Body.First().Bics!)}");
    }

    [TestMethod]
    public void GetNationalIdDetailsAsync()
    {
        var result = _client.NationalIdsService.GetNationalIdDetailsAsync(NationalIdRef, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"NationalId: {result.Body.First().NationalId}");
    }

    [TestMethod]
    public void GetNationalIdsFromBicAsync()
    {
        var result = _client.NationalIdsService.GetNationalIdsFromBicAsync(BicId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"NationalIds: {string.Join(",", result.Body.First().NationalIds!)}");
    }

    [TestMethod]
    public void ValidateNationalIdAsync()
    {
        var result = _client.NationalIdsService.ValidateNationalIdAsync(NationalIdRef, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"IsNationalIdValid: {result.Body.First().IsNationalIdValid}");
    }

    [TestMethod]
    public void GetParticipantDetailsAsync()
    {
        var result = _client.NationalIdsService.GetParticipantDetailsAsync(ParticipantId, CountryId, CurrencyCode, null,
            null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"ParticipantId: {result.Body.First().ParticipantId}");
    }
}