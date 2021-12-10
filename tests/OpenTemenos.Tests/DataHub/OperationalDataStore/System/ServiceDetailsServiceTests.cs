using System;
using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.System;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class ServiceDetailServiceTests : CredentialManagement
{
    private readonly DateTimeOffset _batchDate = DateTimeOffset.Now.AddDays(-1);
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAllReportTimesAsync()
    {
        var result = _client.ServiceAutomationService.GetAllReportTimesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAllReportTimesCOBAsync()
    {
        var result = _client.ServiceAutomationService.GetAllReportTimesCOBAsync(_batchDate).Result;
        Assert.IsNotNull(result.Data);
    }
}