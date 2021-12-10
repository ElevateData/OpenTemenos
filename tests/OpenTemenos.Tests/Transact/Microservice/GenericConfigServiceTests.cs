using Transact;
using Transact.Microservice.GenericConfigs;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass, TestCategory("Transact")]
public class GenericConfigServiceTests : CredentialManagement
{
    private const string ConfigName = "1";
    private const string GroupId = "1";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetEntitlementsByResourceAsync()
    {
        var result = _client.ConfigurationService.GetConfigByNameAsync(ConfigName, GroupId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ModifyConfigurationAsync()
    {
        var groupId = string.Empty;
        var configName = string.Empty;
        var body = new ConfigurationInput();

        var result = _client.ConfigurationService.ModifyConfigurationAsync(groupId, configName, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void AddConfigurationAsync()
    {
        var groupId = string.Empty;
        var configName = string.Empty;
        var body = new Configuration();

        var result = _client.ConfigurationService.AddconfigurationAsync(groupId, configName, body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    public void GetConfigurationsAsync()
    {
        var result = _client.ConfigurationService.GetConfigurationsAsync(GroupId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }
}