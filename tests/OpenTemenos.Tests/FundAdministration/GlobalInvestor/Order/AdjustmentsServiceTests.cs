﻿using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalInvestor.Order.Adjustments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class AdjustmentsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostAdjustmentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.UnderlyingRegAdjustmentService.PostadjustmentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}