using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CompaniesServiceTests : CredentialManagement
{
    private const string CompanyCode = "";
    private const string CurrencyMarket = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetCompaniesAsync()
    {
        var result = _client.CompaniesService.GetCompaniesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetMasterCompanyAsync()
    {
        var result = _client.CompaniesService.GetMasterCompanyAsync(null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCompanyCurrencyExchangeRatesAsync()
    {
        var result = _client.CompaniesService.GetCompanyCurrencyExchangeRatesAsync(CompanyCode, CurrencyMarket, null,
            null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}