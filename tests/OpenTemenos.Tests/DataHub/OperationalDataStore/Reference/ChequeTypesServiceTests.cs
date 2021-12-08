using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class ChequeTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetChequeTypesAsync()
    {
        var result = _client.ChequeTypeService.GetChequeTypesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}