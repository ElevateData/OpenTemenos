﻿using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CashDividendAnnouncement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class CashDividendAnnouncementServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void CreateCashDividendAnnouncementAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CashDividendAnnouncementService
            .CreateCashDividendAnnouncementAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}