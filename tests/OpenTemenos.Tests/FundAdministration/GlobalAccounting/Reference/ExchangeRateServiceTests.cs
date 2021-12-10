﻿using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.ExchangeRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class ExchangeRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateExchangeRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.ExchangeRateService.CreateExchangeRateAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}