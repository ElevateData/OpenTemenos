using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class SPFInformationServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSystemParametersAsync()
    {
        var result = _client.SPFInformationService.GetSystemParametersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}