using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class RateTextsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetRateTextsAsync()
    {
        var result = _client.InterestRateDescriptionService.GetRateTextsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}