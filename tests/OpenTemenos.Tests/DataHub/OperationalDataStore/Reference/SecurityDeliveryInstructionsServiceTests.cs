using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class SecurityDeliveryInstructionsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetSecurityDeliveryInstructionsAsync()
    {
        var result = _client.SecurityDeliveryInstructionService.GetSecurityDeliveryInstructionsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}