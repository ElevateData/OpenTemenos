﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Order.ContractHistory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class ContractHistoryServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod, Ignore("POST method")]
    public void PostContractHistoryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RegisterHistoricalContractService.PostcontracthistoryAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}