﻿using FundAdministration.GlobalAccounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalAccounting.Holding.CiaSubscriptionRight;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CiaSubscriptionRightServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateCapitalIncreaseWithAllotmentOfSubscriptionRightsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CapitalIncreaseAllotmentSubscriptionRightService
            .CreateCapitalIncreaseWithAllotmentOfSubscriptionRightsAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}