﻿using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class EosMultipleSecurityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.MultipleSecurityService
            .CreateExchangeOfSecurityIntoSeveralSecuritiesAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}