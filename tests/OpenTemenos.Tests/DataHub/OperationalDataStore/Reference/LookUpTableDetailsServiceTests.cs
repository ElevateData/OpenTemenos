using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class LookUpTableDetailsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetEbLookupsAsync()
    {
        var result = _client.LookupTableService.GetEbLookupsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}