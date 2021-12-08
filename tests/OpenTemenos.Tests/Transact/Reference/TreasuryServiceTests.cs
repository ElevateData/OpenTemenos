using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class TreasuryServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string AgreementTypeId = "";
    private const string DealMethodId = "";
    private const string RevaluationTypeId = "";
    private const string CurrencyOrPair = "Currency";

    [TestMethod]
    public void GetForexAgreementTypesAsync()
    {
        var result = _client.TreasuryService.GetForexAgreementTypesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"AgreementTypeId: {result.Body.First().AgreementTypeId}");
    }

    [TestMethod]
    public void GetForexAgreementTypeAsync()
    {
        var result = _client.TreasuryService
            .GetForexAgreementTypeAsync(AgreementTypeId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"AgreementTypeId: {result.Body.First().AgreementTypeId}");
    }

    [TestMethod]
    public void GetForexDealMethodsAsync()
    {
        var result = _client.TreasuryService.GetForexDealMethodsAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"DealMethodId: {result.Body.First().DealMethodId}");
    }

    [TestMethod]
    public void GetForexDealMethodAsync()
    {
        var result = _client.TreasuryService.GetForexDealMethodAsync(DealMethodId,null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"DealMethodId: {result.Body.First().DealMethodId}");
    }

    [TestMethod]
    public void GetForexRevaluationTypesAsync()
    {
        var result = _client.TreasuryService.GetForexRevaluationTypesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"RevaluationTypeId: {result.Body.First().RevaluationTypeId}");
    }

    [TestMethod]
    public void GetForexRevaluationTypeAsync()
    {
        var result = _client.TreasuryService.GetForexRevaluationTypeAsync(RevaluationTypeId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"DisplayName: {result.Body.First().DisplayName}");
    }

    [TestMethod]
    public void GetTreasurySettingsAsync()
    {
        var result = _client.TreasuryService.GetTreasurySettingsAsync(null, null, null, null, null, null, null, null,null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CompanyId: {result.Body.First().CompanyId}");
        Debug.WriteLine($@"LocalCurrencyId: {result.Body.First().LocalCurrencyId}");
        Debug.WriteLine($@"RevaluationCurrencyId: {result.Body.First().RevaluationCurrencyId}");
    }

    [TestMethod]
    public void GetPeriodDatesAsync()
    {
        var result = _client.TreasuryService.GetPeriodDatesAsync(CurrencyOrPair, null, null, null, null, null, null, null, null,null,null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Date: {result.Body.First().Date}");
    }

    [TestMethod]
    public void GetDealMethodsAsync()
    {
        var result = _client.TreasuryService.GetDealMethodsAsync(null, null, null, null, null, null, null, null,null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"PaymentAccountId: {result.Body.First().PaymentAccountId}");
        Debug.WriteLine($@"PaymentCurrencyId: {result.Body.First().PaymentCurrencyId}");
        Debug.WriteLine($@"MethodId: {result.Body.First().MethodId}");
    }

    [TestMethod]
    public void GetAgreementTypesAsync()
    {
        var result = _client.TreasuryService.GetAgreementTypesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"AgreementTypeId: {result.Body.First().AgreementTypeId}");
    }

    [TestMethod]
    public void GetAgreementTypeAsync()
    {
        var result = _client.TreasuryService.GetAgreementTypeAsync(AgreementTypeId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}