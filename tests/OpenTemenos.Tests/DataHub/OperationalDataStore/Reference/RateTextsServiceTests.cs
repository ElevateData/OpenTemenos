using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class RateTextServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetRateTextsAsync()
    {
        var result = _client.InterestRateDescriptionService.GetRateTextsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}