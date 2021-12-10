using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class USCustomerRatingListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUSCustomerRatingListAsync()
    {
        var result = _client.UsModelBankCustomerRiskRatingService.GetUSCustomerRatingListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}