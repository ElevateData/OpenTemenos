using Transact;
using Transact.System.ServiceAutomations;

namespace OpenTemenos.Tests.Transact.System;

[TestClass, TestCategory("Transact")]
public class ServiceAutomationServiceTests : CredentialManagement
{
    private const string BusinessClosureDate = "20200101";
    private const string CompanyIdPath = "1";
    private const string ServiceId = "1";
    private const string WorkProfileId = "1";
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateNewProcessAsync()
    {
        var processId = string.Empty;
        var payload = new NewProcess();
        var result = _client.ServiceAutomationService.CreateNewProcessAsync(processId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendNewProcessAsync()
    {
        var processId = string.Empty;
        var payload = new NewProcess();
        var result = _client.ServiceAutomationService.AmendNewProcessAsync(processId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetServiceAsync()
    {
        var result = _client.ServiceAutomationService.GetServiceAsync(ServiceId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateNewServiceAsync()
    {
        var serviceId = string.Empty;
        var payload = new NewService();
        var result = _client.ServiceAutomationService.CreateNewServiceAsync(serviceId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void AmendServiceAsync()
    {
        var serviceId = string.Empty;
        var payload = new NewService();
        var result = _client.ServiceAutomationService.AmendServiceAsync(serviceId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetServiceWorkProfileAsync()
    {
        var result = _client.ServiceAutomationService.GetServiceWorkProfileAsync(WorkProfileId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateServiceWorkProfileAsync()
    {
        var workProfileId = string.Empty;
        var payload = new ServiceWorkProfile();
        var result = _client.ServiceAutomationService.CreateServiceWorkProfileAsync(workProfileId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendServiceWorkProfileAsync()
    {
        var workProfileId = string.Empty;
        var payload = new ServiceWorkProfile();
        var result = _client.ServiceAutomationService.AmendServiceWorkProfileAsync(workProfileId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetServiceStatusAsync()
    {
        var result = _client.ServiceAutomationService.GetAvailableServicesAsync(ServiceId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAllServicesStatusAsync()
    {
        var result = _client.ServiceAutomationService.GetAllServicesStatusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetServiceProcessTimesAsync()
    {
        var result = _client.ServiceAutomationService.GetServiceProcessTimesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetReportTimesAsync()
    {
        var result = _client.ServiceAutomationService.GetReportTimesAsync(BusinessClosureDate)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAllServiceWorkProfilesAsync()
    {
        var result = _client.ServiceAutomationService.GetAllServiceWorkProfilesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetBusinessClosureErrorForCompanyAsync()
    {
        var result = _client.ServiceAutomationService.GetBusinessClosureErrorForCompanyAsync(CompanyIdPath)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAvailableServicesAsync()
    {
        var result = _client.ServiceAutomationService.GetAvailableServicesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCobProgressAsync()
    {
        var result = _client.ServiceAutomationService.GetCobProgressAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendBusinessClosureErrorAsync()
    {
        var errorDetailId = string.Empty;
        var payload = new BusinessClosureError();
        var result = _client.ServiceAutomationService.AmendBusinessClosureErrorAsync(errorDetailId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}