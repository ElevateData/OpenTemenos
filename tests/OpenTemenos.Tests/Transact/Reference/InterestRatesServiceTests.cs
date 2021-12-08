using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;
using Transact.Reference.InterestRates;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class InterestRatesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string RateId = "1";
    private const string Date = "";

    [TestMethod]
    public void GetRateTextsAsync()
    {
        var result = _client.InterestRatesService
            .GetRateTextsAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"RateId: {result.Body.First().RateTextId}");
    }

    [TestMethod]
    public void GetBasicInterestAsync()
    {
        var result = _client.InterestRatesService.GetBasicInterestAsync(RateId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreateBasicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterest();
        var result = _client.InterestRatesService.CreateBasicInterestAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdateBasicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterest();
        var result = _client.InterestRatesService.UpdateBasicInterestAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBasicInterestChangeDatesAsync()
    {
        var result = _client.InterestRatesService
            .GetBasicInterestChangeDatesAsync(RateId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"EffectiveDate: {result.Body.First().EffectiveDate}");
    }

    [TestMethod]
    public void GetBasicInterestRateChangesAsync()
    {
        var result = _client.InterestRatesService.GetBasicInterestRateChangesAsync(RateId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicInterestAsync()
    {
        var result = _client.InterestRatesService.GetPeriodicInterestAsync(RateId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreatePeriodicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicInterest();
        var result = _client.InterestRatesService.CreatePeriodicInterestAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdatePeriodicInterestAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicInterest();
        var result = _client.InterestRatesService.UpdatePeriodicInterestAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicRateChangesAsync()
    {
        var result = _client.InterestRatesService
            .GetPeriodicRateChangesAsync(Date, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"PeriodicInterestId: {result.Body.First().PeriodicInterestId}");
    }

    [TestMethod]
    public void GetBasicInterestNameAsync()
    {
        var result = _client.InterestRatesService.GetBasicInterestNameAsync(RateId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreateBasicInterestNameAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterestName();
        var result = _client.InterestRatesService.CreateBasicInterestNameAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdateBasicInterestNameAsync()
    {
        var rateId = string.Empty;
        var payload = new BasicInterestName();
        var result = _client.InterestRatesService.UpdateBasicInterestNameAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicRateNameAsync()
    {
        var result = _client.InterestRatesService.GetPeriodicRateNameAsync(RateId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreatePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateName();
        var result = _client.InterestRatesService.CreatePeriodicRateNameAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdatePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateName();
        var result = _client.InterestRatesService.UpdatePeriodicRateNameAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeletePeriodicRateNameAsync()
    {
        var rateId = string.Empty;
        var payload = new PeriodicRateNameDelete();
        var result = _client.InterestRatesService.DeletePeriodicRateNameAsync(rateId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}