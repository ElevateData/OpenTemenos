using System;
using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.System;

[TestClass]
public class ServiceDetailsServiceTests : CredentialManagement
{
    private readonly DateTimeOffset _batchDate = DateTimeOffset.Now.AddDays(-1);
    private readonly ISystemClient _client = new SystemClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetAllReportTimesAsync()
    {
        var result = _client.ServiceAutomationService.GetAllReportTimesAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAllReportTimesCOBAsync()
    {
        var result = _client.ServiceAutomationService.GetAllReportTimesCOBAsync(_batchDate, null).Result;
        Assert.IsNotNull(result.Data);
    }
}