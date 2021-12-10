using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsSortCodesServicesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsRoutingAsync()
    {
        var result = _client.UsSortCodesServicesService
            .GetUsRoutingAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}