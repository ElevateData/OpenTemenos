using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class LcDetailServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetIncoTermsAsync()
    {
        var result = _client.LetterOfCreditService.GetIncoTermsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLcTenorsAsync()
    {
        var result = _client.LetterOfCreditService.GetLcTenorsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}