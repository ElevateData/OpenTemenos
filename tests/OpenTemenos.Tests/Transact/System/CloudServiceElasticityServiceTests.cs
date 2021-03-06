using Transact;
using Transact.System.CloudServiceElasticities;

namespace OpenTemenos.Tests.Transact.System;

[TestClass, TestCategory("Transact")]
public class CloudServiceElasticityServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateServiceElasticCleanupAsync()
    {
        var serverId = string.Empty;
        var payload = new ServiceElasticCleanup();
        var result = _client.CloudServiceElasticityService.CreateServiceElasticCleanupAsync(serverId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendServiceElasticParameterAsync()
    {
        var settingId = string.Empty;
        var payload = new ServiceElasticParameter();
        var result = _client.CloudServiceElasticityService.AmendServiceElasticParameterAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateServiceElasticProfileAsync()
    {
        var workProfileId = string.Empty;
        var payload = new ServiceElasticProfile();
        var result = _client.CloudServiceElasticityService.CreateServiceElasticProfileAsync(workProfileId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendServiceElasticProfileAsync()
    {
        var workProfileId = string.Empty;
        var payload = new ServiceElasticProfile();
        var result = _client.CloudServiceElasticityService.AmendServiceElasticProfileAsync(workProfileId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendSystemParameterElasticAsync()
    {
        var settingId = string.Empty;
        var payload = new SystemParameterElastic();
        var result = _client.CloudServiceElasticityService.AmendSystemParameterElasticAsync(settingId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAgentElasticCheckAsync()
    {
        var result = _client.CloudServiceElasticityService.GetAgentElasticCheckAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAgentElasticCheckDetailsAsync()
    {
        var result = _client.CloudServiceElasticityService.GetAgentElasticCheckDetailsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}