﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.TradingDeskRates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class TradingDeskRatesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostTradingDeskRatesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TradingDeskValidationService.PosttradingdeskratesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}