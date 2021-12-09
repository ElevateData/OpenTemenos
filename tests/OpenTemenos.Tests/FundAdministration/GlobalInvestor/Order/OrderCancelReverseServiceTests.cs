﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.OrderCancelReverse;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class OrderCancelReverseServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostOrderCancelReverseAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OrderCancellationService.PostordercancelreverseAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}