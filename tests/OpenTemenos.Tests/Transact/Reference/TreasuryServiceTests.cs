using System.Linq;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class TreasuryServiceTests : CredentialManagement
{
    private const string AgreementTypeId = "";
    private const string DealMethodId = "";
    private const string RevaluationTypeId = "";
    private const string CurrencyOrPair = "Currency";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetForexAgreementTypesAsync()
    {
        var result = _client.TreasuryService.GetForexAgreementTypesAsync(null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexAgreementTypeAsync()
    {
        var result = _client.TreasuryService
            .GetForexAgreementTypeAsync(AgreementTypeId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexDealMethodsAsync()
    {
        var result = _client.TreasuryService.GetForexDealMethodsAsync(null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexDealMethodAsync()
    {
        var result = _client.TreasuryService
            .GetForexDealMethodAsync(DealMethodId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexRevaluationTypesAsync()
    {
        var result = _client.TreasuryService
            .GetForexRevaluationTypesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexRevaluationTypeAsync()
    {
        var result = _client.TreasuryService
            .GetForexRevaluationTypeAsync(RevaluationTypeId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetTreasurySettingsAsync()
    {
        var result = _client.TreasuryService
            .GetTreasurySettingsAsync(null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetPeriodDatesAsync()
    {
        var result = _client.TreasuryService
            .GetPeriodDatesAsync(CurrencyOrPair, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDealMethodsAsync()
    {
        var result = _client.TreasuryService.GetDealMethodsAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAgreementTypesAsync()
    {
        var result = _client.TreasuryService.GetAgreementTypesAsync(null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAgreementTypeAsync()
    {
        var result = _client.TreasuryService
            .GetAgreementTypeAsync(AgreementTypeId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}