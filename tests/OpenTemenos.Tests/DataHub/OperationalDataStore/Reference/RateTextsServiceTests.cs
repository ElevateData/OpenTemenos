using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class RateTextsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetRateTextsAsync()
    {
        var result = _client.InterestRateDescriptionService.GetRateTextsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}