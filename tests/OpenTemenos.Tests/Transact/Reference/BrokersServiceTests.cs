using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BrokersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBrokersAsync()
    {
        var result = _client.BrokersService.GetBrokersAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}