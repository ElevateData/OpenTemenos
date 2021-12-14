﻿using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionTransactionsRebookings;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class OptionTransactionsRebookingServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void OptionTransactionsRebookingAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionTransactionRebookingService
            .OptionTransactionsRebookingAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}