using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class DealerDeskDetailServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetForexAgreementTypeAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetForexAgreementTypeAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetForexDealMethodAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetForexDealMethodAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetForexRevaluationTypeAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetForexRevaluationTypeAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAgreementTypeAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetAgreementTypeAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetDealersListAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetDealersListAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetForexAgreementTypesAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetForexAgreementTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetForexDealMethodsAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetForexDealMethodsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetForexRevaluationTypesAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetForexRevaluationTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAgreementTypesAsync()
    {
        var result = _client.TreasuryDealerDeskService.GetAgreementTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}