using System.Linq;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsSortCodesServicesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsRoutingAsync()
    {
        var result = _client.UsSortCodesServicesService
            .GetUsRoutingAsync(null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}