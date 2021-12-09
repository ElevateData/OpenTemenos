using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class InterestBasisServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetInterestBasisAsync()
    {
        var result = _client.InterestBaseService.GetInterestBasisAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}