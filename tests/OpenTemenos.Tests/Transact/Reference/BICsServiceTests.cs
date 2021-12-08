using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BICsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private readonly string _bicId = string.Empty;
    private readonly string _countryCode = string.Empty;

    [TestMethod]
    public void GetBICStatusAsync()
    {
        var result = _client.BICsService.GetBICStatusAsync(_bicId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod]
    public void ValidateBICAsync()
    {
        var result = _client.BICsService.ValidateBICAsync(_bicId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod]
    public void GetLEIFromBICAsync()
    {
        var result = _client.BICsService.GetLEIFromBICAsync(_bicId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod]
    public void GetBICIdentifierAsync()
    {
        var result = _client.BICsService
            .GetBICIdentifierAsync(_countryCode, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}