using Transact;
using Transact.Holding.Collaterals;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CollateralsServiceTests : CredentialManagement
{
    private const string CustomerId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCustomerCollateralsAsync()
    {
        var payload = new CustomerCollaterals();
        var result = _client.CustomerCollateralService
            .CreateCustomerCollateralsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCustomerCollateralsAsync()
    {
        var collateralId = string.Empty;
        var payload = new CustomerCollaterals();
        var result = _client.CustomerCollateralService
            .UpdateCustomerCollateralsAsync(collateralId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCustomerCollateralsAsync()
    {
        var result = _client.CustomerCollateralService
            .GetCustomerCollateralsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}