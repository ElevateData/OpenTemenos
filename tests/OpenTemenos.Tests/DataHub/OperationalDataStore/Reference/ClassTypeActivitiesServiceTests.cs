using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class ClassTypeActivitiesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string _entityTypeId = string.Empty;

    [TestMethod]
    public void GetClassTypeActivitiesAsync()
    {
        var result = _client.ClassTypeActivityService.GetClassTypeActivitiesAsync(_entityTypeId).Result;
        Assert.IsNotNull(result.Data);
    }
}