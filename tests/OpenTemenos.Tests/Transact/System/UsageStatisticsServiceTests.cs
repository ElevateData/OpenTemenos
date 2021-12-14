﻿using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
[TestCategory("Transact")]
public class UsageStatisticServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsageStatsAsync()
    {
        var result = _client.UsageStatisticService.GetUsageStatsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}