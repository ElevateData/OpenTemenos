using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CompaniesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string CompanyCode = "";
    private const string CurrencyMarket = "";

    [TestMethod]
    public void GetCompaniesAsync()
    {
        var result = _client.CompaniesService.GetCompaniesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CompanyId: {result.Body.First().CompanyId}");
    }
    [TestMethod]
    public void GetMasterCompanyAsync()
    {
        var result = _client.CompaniesService.GetMasterCompanyAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CompanyId: {result.Body.First().CompanyId}");
    }
    [TestMethod]
    public void GetCompanyCurrencyExchangeRatesAsync()
    {
        var result = _client.CompaniesService.GetCompanyCurrencyExchangeRatesAsync(CompanyCode, CurrencyMarket, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"LocalCurrencyId: {result.Body.First().LocalCurrencyId}");
    }
}