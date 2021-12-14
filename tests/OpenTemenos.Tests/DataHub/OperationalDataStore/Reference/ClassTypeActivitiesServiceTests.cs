using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class ClassTypeActivityServiceTests : CredentialManagement
{
    private const string EntityTypeId = "US0010001";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetClassTypeActivitiesAsync()
    {
        var result = _client.ClassTypeActivityService.GetClassTypeActivitiesAsync(EntityTypeId).Result;
        Assert.IsNotNull(result.Data);
    }
}