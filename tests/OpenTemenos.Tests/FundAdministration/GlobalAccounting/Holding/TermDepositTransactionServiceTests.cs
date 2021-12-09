﻿using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.TermDepositTransaction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class TermDepositTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void TermDepositTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TimeTermDepositService.TermDepositTransactionAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}