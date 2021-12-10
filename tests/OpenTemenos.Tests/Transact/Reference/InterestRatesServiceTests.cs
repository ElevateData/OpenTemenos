using Transact;
using Transact.Reference.InterestRates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class InterestRatesServiceTests : CredentialManagement
{
    private const string RateId = "1";
    private const string Date = "20201209";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetRateTextsAsync()
    {
        var result = _client.InterestRatesService
            .GetRateTextsAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBasicInterestAsync()
    {
        var result = _client.InterestRatesService.GetBasicInterestAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateBasicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterest();
        var result = _client.InterestRatesService
            .CreateBasicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateBasicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterest();
        var result = _client.InterestRatesService
            .UpdateBasicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBasicInterestChangeDatesAsync()
    {
        var result = _client.InterestRatesService
            .GetBasicInterestChangeDatesAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBasicInterestRateChangesAsync()
    {
        var result = _client.InterestRatesService.GetBasicInterestRateChangesAsync(RateId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicInterestAsync()
    {
        var result = _client.InterestRatesService.GetPeriodicInterestAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePeriodicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicInterest();
        var result = _client.InterestRatesService
            .CreatePeriodicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePeriodicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicInterest();
        var result = _client.InterestRatesService
            .UpdatePeriodicInterestAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicRateChangesAsync()
    {
        var result = _client.InterestRatesService
            .GetPeriodicRateChangesAsync(Date).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBasicInterestNameAsync()
    {
        var result = _client.InterestRatesService.GetBasicInterestNameAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateBasicInterestNameAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterestName();
        var result = _client.InterestRatesService
            .CreateBasicInterestNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateBasicInterestNameAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterestName();
        var result = _client.InterestRatesService
            .UpdateBasicInterestNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicRateNameAsync()
    {
        var result = _client.InterestRatesService.GetPeriodicRateNameAsync(RateId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateName();
        var result = _client.InterestRatesService
            .CreatePeriodicRateNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateName();
        var result = _client.InterestRatesService
            .UpdatePeriodicRateNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateNameDelete();
        var result = _client.InterestRatesService
            .DeletePeriodicRateNameAsync(rateId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}