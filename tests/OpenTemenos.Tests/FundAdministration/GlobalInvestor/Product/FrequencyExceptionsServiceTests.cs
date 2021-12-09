using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FrequencyExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FrequencyExceptionsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostFrequencyExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService.PostFrequencyExceptionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostFrequencyExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService.PostFrequencyExceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFrequencyExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FrequentExceptionService.PutFrequencyExceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFrequencyExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FrequentExceptionService.DeleteFrequencyExceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFrequencyExceptionsByInternalIdAsync()
    {
        var result = _client.FrequentExceptionService.GetFrequencyExceptionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFrequencyExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService.PutFrequencyExceptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFrequencyExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FrequentExceptionService.DeleteFrequencyExceptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}