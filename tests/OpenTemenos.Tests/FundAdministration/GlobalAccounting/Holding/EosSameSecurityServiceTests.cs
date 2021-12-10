﻿using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.EosSameSecurity;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class EosSameSecurityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.SameSecurityService
            .CreateExchangeOfSecurityIntoExistingSecurityAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}