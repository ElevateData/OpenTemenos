using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class EvidenceTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetEvidenceTypesAsync()
    {
        var result = _client.EvidenceTypeService.GetEvidenceTypesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}
