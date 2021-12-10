using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class QuestionnaireTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetQuestionnaireTypesAsync()
    {
        var result = _client.QuestionnaireTypeService.GetQuestionnaireTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}