using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
[TestCategory("Transact")]
public class IBANServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string AccountId = "100005";
    private readonly string BankId = "";
    private readonly string CountryId = "US";
    private readonly string IbanId = "GB63DEMO60161300100005";

    [TestMethod]
    public void GetBICfromIBANAsync()
    {
        var result = _client.IBANService.GetBICfromIBANAsync(IbanId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetIBANDetailsAsync()
    {
        var result = _client.IBANService.GetIBANDetailsAsync(IbanId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetIBANFromBBANAsync()
    {
        var result = _client.IBANService
            .GetIBANFromBBANAsync(IbanId, CountryId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetIBANNumberGeneratedAsync()
    {
        var result = _client.IBANService
            .GetIBANNumberGeneratedAsync(AccountId, BankId, CountryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetIBANStructureAsync()
    {
        var result = _client.IBANService.GetIBANStructureAsync(CountryId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void ValidateIBANAsync()
    {
        var result = _client.IBANService.ValidateIBANAsync(IbanId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}