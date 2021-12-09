﻿using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class AccountListServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetNostroAccountListAsync()
    {
        var result = _client.NostroVostroAccountListService.GetNostroAccountListAsync().Result;
        Assert.IsNotNull(result.Data);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Data)}");
    }

    [TestMethod]
    public void GetVostroAccountListAsync()
    {
        var result = _client.NostroVostroAccountListService.GetVostroAccountListAsync(null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Data)}");
    }
}