﻿using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FundShareTransaction;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class FundShareTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void FundShareTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ShareholderService.FundSharetransactionAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}