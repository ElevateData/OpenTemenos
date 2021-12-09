﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FrequencyExceptionDays;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FrequencyExceptionDaysServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostFrequencyExceptionDaysByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FrequentExceptionDayService
            .PostFrequencyexceptiondaysByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFrequencyExceptionDaysAsync()
    {
        var payload = new _0Payload();
        var result = _client.FrequentExceptionDayService
            .PostFrequencyexceptiondaysAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFrequencyExceptionDaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FrequentExceptionDayService
            .PutFrequencyexceptiondaysAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFrequencyExceptionDaysAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FrequentExceptionDayService
            .DeleteFrequencyexceptiondaysAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFrequencyExceptionDaysByInternalIdAsync()
    {
        var result = _client.FrequentExceptionDayService
            .GetFrequencyexceptiondaysByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFrequencyExceptionDaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FrequentExceptionDayService
            .PutFrequencyexceptiondaysByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFrequencyExceptionDaysByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FrequentExceptionDayService
            .DeleteFrequencyexceptiondaysByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}