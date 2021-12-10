using System;
using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass, TestCategory("Transact")]
public class ApiServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    //TODO: compare Azure stored results against GitHub. There are already some differences.
    public void GetApiDocsAsync()
    {
        var result = _client.ApiService.GetApiDocsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    //TODO: validate versioning issues against these results
    public void GetApisAsync()
    {
        var result = _client.ApiService.GetApisAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetInternalApisAsync()
    {
        //TODO: Body is missing from response
        //var result = _client.ApiService.GetInternalApisAsync().Result;
        //Assert.IsNotNull(result.Body);
        //Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
        throw new NotImplementedException("Body is missing from response");
    }
}