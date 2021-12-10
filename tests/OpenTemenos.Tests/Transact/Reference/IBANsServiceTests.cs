using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class IBANsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string AccountId = "";
    private readonly string BankId = "";
    private readonly string CountryId = "US";
    private readonly string IbanId = "";

    [TestMethod]
    public void GetBICfromIBANAsync()
    {
        var result = _client.IBANsService.GetBICfromIBANAsync(IbanId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetIBANDetailsAsync()
    {
        var result = _client.IBANsService.GetIBANDetailsAsync(IbanId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetIBANFromBBANAsync()
    {
        var result = _client.IBANsService
            .GetIBANFromBBANAsync(IbanId, CountryId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetIBANNumberGeneratedAsync()
    {
        var result = _client.IBANsService
            .GetIBANNumberGeneratedAsync(AccountId, BankId, CountryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetIBANStructureAsync()
    {
        var result = _client.IBANsService.GetIBANStructureAsync(CountryId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void ValidateIBANAsync()
    {
        var result = _client.IBANsService.ValidateIBANAsync(IbanId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}