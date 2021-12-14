using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FrequencyExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class FrequencyExceptionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFrequencyExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService
            .PostFrequencyExceptionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFrequencyExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService
            .PostFrequencyExceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFrequencyExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FrequentExceptionService.PutFrequencyExceptionsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFrequencyExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FrequentExceptionService
            .DeleteFrequencyExceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFrequencyExceptionsByInternalIdAsync()
    {
        var result = _client.FrequentExceptionService
            .GetFrequencyExceptionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFrequencyExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService
            .PutFrequencyExceptionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFrequencyExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService
            .DeleteFrequencyExceptionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}