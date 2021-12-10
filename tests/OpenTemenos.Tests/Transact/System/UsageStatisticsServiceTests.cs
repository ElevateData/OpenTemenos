using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class UsageStatisticsServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsageStatsAsync()
    {
        var result = _client.UsageStatisticsService.GetUsageStatsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}