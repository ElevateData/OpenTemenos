using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class CompaniesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetCompaniesAsync()
    {
        var result = _client.LegalEntityService.GetCompaniesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}