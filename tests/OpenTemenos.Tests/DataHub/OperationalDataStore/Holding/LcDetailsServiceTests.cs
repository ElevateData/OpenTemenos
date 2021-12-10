using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class LcDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetIncoTermsAsync()
    {
        var result = _client.LetterOfCreditService.GetIncoTermsAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLcTenorsAsync()
    {
        var result = _client.LetterOfCreditService.GetLcTenorsAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}