﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Reference.CurrencyHolidays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

[TestClass]
public class CurrencyHolidaysServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetCurHolAsync()
    {
        var result = _client.CurrencyHolidayService
            .GetCurHolAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("POST method")]
    public void PostCurrencyholidayAsync()
    {
        var body = new _0Payload();
        var result = _client.CurrencyHolidayService.PostCurrencyholidayAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("PUT method")]
    public void PutCurrencyholidaysingleAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.CurrencyHolidayService.PutCurrencyholidaysingleAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("DELETE method")]
    public void DeleteCurHolByAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.CurrencyHolidayService.DeleteCurHolByAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod]
    public void GetCurHolByIdAsync()
    {
        var internalId = string.Empty;
        var result = _client.CurrencyHolidayService
            .GetCurHolByIdAsync(null, null, null, null, null, null, null, null, null, null, internalId).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("PUT method")]
    public void PutCurHolByIdAsync()
    {
        var body = new _0Payload();
        var internalId = string.Empty;
        var result = _client.CurrencyHolidayService.PutCurHolByIdAsync(null, null, null, null, null, internalId, body).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("DELETE method")]
    public void DeleteCurHolByIdAsync()
    {
        var body = new _0Payload();
        var internalId = string.Empty;
        var result = _client.CurrencyHolidayService.DeleteCurHolByIdAsync(null, null, null, null, null, internalId, body).Result;
        Assert.IsNotNull(result.Body);
    }
}