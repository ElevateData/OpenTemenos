using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass, TestCategory("Transact")]
public class ProcessWorkFlowServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPendingWorkflowsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetPendingWorkflowsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetWorkflowPendingActivitiesAsync()
    {
        var result = _client.ProcessWorkFlowService.GetWorkflowPendingActivitiesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetTransactionsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetRolelessTransactionsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetRolelessTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetWorkflowParticipantsAsync()
    {
        var result = _client.ProcessWorkFlowService.GetWorkflowParticipantsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}