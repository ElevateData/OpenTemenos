using Transact;
using Transact.Order.Sweeps;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class SweepServiceTests : CredentialManagement
{
    private const string SweepId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSweepsAsync()
    {
        var result = _client.AccountSweepService.GetSweepsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSweepAsync()
    {
        var payload = new Sweep();
        var result = _client.AccountSweepService.CreateSweepAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSweepAsync()
    {
        var result = _client.AccountSweepService.GetSweepAsync(SweepId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSweepAsync()
    {
        var sweepId = string.Empty;
        var payload = new Sweep();
        var result = _client.AccountSweepService.UpdateSweepAsync(sweepId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSweepAsync()
    {
        var sweepId = string.Empty;
        var result = _client.AccountSweepService.DeleteSweepAsync(sweepId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void RejectSweepAsync()
    {
        var sweepId = string.Empty;
        var payload = new SweepDelete();
        var result = _client.AccountSweepService.RejectSweepAsync(sweepId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApproveSweepAsync()
    {
        var sweepId = string.Empty;
        var result = _client.AccountSweepService.ApproveSweepAsync(sweepId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSweepCancellationsAsync()
    {
        var result = _client.AccountSweepService.GetSweepCancellationsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}