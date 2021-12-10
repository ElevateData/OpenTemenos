using Transact;
using Transact.Order.CashManagementSweep;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class CashManagementSweepServiceTests : CredentialManagement
{
    private const string AccountId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateMaintainBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateMaintainBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateMaintainBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateMaintainBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSurplusBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateSurplusBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSurplusBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateSurplusBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateZeroBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateZeroBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateZeroBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateZeroBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateFXCurrencyMaintainBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateFXCurrencyMaintainBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFXCurrencyMaintainBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateFXCurrencyMaintainBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateFXSurplusBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateFXSurplusBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFXSurplusBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateFXSurplusBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateFXZeroBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.CreateFXZeroBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFXZeroBalanceSweepsAsync()
    {
        var payload = new MaintainBalanceSweeps();
        var result = _client.CashManagementSweepService.UpdateFXZeroBalanceSweepsAsync(AccountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}