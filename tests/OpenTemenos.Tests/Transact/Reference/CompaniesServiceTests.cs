using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class CompanyServiceTests : CredentialManagement
{
    private const string CompanyCode = "";
    private const string CurrencyMarket = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCompaniesAsync()
    {
        var result = _client.CompanyService.GetCompaniesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetMasterCompanyAsync()
    {
        var result = _client.CompanyService.GetMasterCompanyAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCompanyCurrencyExchangeRatesAsync()
    {
        var result = _client.CompanyService.GetCompanyCurrencyExchangeRatesAsync(CompanyCode, CurrencyMarket).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}