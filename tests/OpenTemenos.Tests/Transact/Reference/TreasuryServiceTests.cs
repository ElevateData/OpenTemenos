using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class TreasuryServiceTests : CredentialManagement
{
    private const string AgreementTypeId = "";
    private const string DealMethodId = "";
    private const string RevaluationTypeId = "";
    private const string CurrencyOrPair = "Currency";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetForexAgreementTypesAsync()
    {
        var result = _client.TreasuryService.GetForexAgreementTypesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexAgreementTypeAsync()
    {
        var result = _client.TreasuryService
            .GetForexAgreementTypeAsync(AgreementTypeId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexDealMethodsAsync()
    {
        var result = _client.TreasuryService.GetForexDealMethodsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexDealMethodAsync()
    {
        var result = _client.TreasuryService
            .GetForexDealMethodAsync(DealMethodId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexRevaluationTypesAsync()
    {
        var result = _client.TreasuryService
            .GetForexRevaluationTypesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetForexRevaluationTypeAsync()
    {
        var result = _client.TreasuryService
            .GetForexRevaluationTypeAsync(RevaluationTypeId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetTreasurySettingsAsync()
    {
        var result = _client.TreasuryService
            .GetTreasurySettingsAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetPeriodDatesAsync()
    {
        var result = _client.TreasuryService
            .GetPeriodDatesAsync(CurrencyOrPair).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDealMethodsAsync()
    {
        var result = _client.TreasuryService.GetDealMethodsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAgreementTypesAsync()
    {
        var result = _client.TreasuryService.GetAgreementTypesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAgreementTypeAsync()
    {
        var result = _client.TreasuryService
            .GetAgreementTypeAsync(AgreementTypeId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}