using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class USIndustrylistServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetUSIndustrylistAsync()
    {
        var result = _client.UsModelBankUsIndustryClassificationService.GetUSIndustrylistAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}