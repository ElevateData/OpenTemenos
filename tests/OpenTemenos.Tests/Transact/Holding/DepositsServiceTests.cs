using System;
using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class DepositsServiceTests : CredentialManagement
{
    private const string DepositId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void GetDepositDetailsAsync()
    {
        var result = _client.DepositService
            .GetDepositDetailsAsync(DepositId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}