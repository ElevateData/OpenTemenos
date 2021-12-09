﻿using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalInvestor.Order.DividendRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class DividendRatesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostDividendRatesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DividendRateService.PostDividendRatesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}