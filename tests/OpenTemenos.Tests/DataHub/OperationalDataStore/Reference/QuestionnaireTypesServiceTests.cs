using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class QuestionnaireTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetQuestionnaireTypesAsync()
    {
        var result = _client.QuestionnaireTypeService.GetQuestionnaireTypesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}