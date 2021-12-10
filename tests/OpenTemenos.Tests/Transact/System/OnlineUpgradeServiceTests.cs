using Transact;
using Transact.System.OnlineUpgrade;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class OnlineUpgradeServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void AddServerOnlineUpgradeAsync()
    {
        var payload = new ServerOnlineupgrade();
        var result = _client.OnlineUpgradeService.AddServerOnlineupgradeAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void StopRestructureServiceAsync()
    {
        var payload = new RestructureService();
        var result = _client.OnlineUpgradeService.StopRestructureServiceAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void StartRestructureFeederAsync()
    {
        var payload = new RestructureService();
        var result = _client.OnlineUpgradeService.StartRestructureFeederAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void StopRestructureFeederAsync()
    {
        var payload = new RestructureService();
        var result = _client.OnlineUpgradeService.StopRestructureFeederAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void StartPrimaryDataReleaseAsync()
    {
        var payload = new RestructureService();
        var result = _client.OnlineUpgradeService.StartPrimaryDatareleaseAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void StartSecondaryDataReleaseAsync()
    {
        var payload = new RestructureService();
        var result = _client.OnlineUpgradeService.StartSecondaryDatareleaseAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeCriticalRecordAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeCriticalRecordAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeNonCriticalRecordsAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeNonCriticalRecordsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeRestructureFileListAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeRestructureFilelistAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeFeederDrilldownAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeFeederDrilldownAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeFeederDrilldownChannelAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeFeederDrilldownChannelAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeJobTimesPrimaryAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeJobTimesPrimaryAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOnlineUpgradeJobTimesSecondaryAsync()
    {
        var result = _client.OnlineUpgradeService.GetOnlineUpgradeJobTimesSecondaryAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}