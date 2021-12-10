using Transact;
using Transact.System.DataEventStreamings;

namespace OpenTemenos.Tests.Transact.System;

[TestClass, TestCategory("Transact")]
public class DataEventStreamingServiceTests : CredentialManagement
{
    private const string CompanyMnemonic = "1";
    private const string ApplicationName = "1";
    private const string PatternType = "1";
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetFileNamesAsync()
    {
        var result = _client.DataEventStreamingService.GetFileNamesAsync(CompanyMnemonic, ApplicationName, PatternType)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ConfigureDESAsync()
    {
        var settingId = string.Empty;
        var payload = new DES();
        var result = _client.DataEventStreamingService.ConfigureDESAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void EnableCommitCaptureAsync()
    {
        var settingId = string.Empty;
        var payload = new CommitCapture();
        var result = _client.DataEventStreamingService.EnableCommitCaptureAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCommitCaptureEnabledAsync()
    {
        var result = _client.DataEventStreamingService.GetCommitCaptureEnabledAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetUnprocessedCountAsync()
    {
        var result = _client.DataEventStreamingService.GetUnprocessedCountAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}