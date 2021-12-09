﻿using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Order.StockExchangeTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Order;


[TestClass]
public class StockExchangeTransactionServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateStockExchangeTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockExchangeTransactionBookingService.CreateStockExchangeTransactionAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}
