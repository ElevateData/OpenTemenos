using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class UsSafeDepositsServiceTests : CredentialManagement
{
    private const string AccountId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsSafeDepositBoxOverviewAsync()
    {
        var result = _client.UsModelBank.SafeDepositService.GetUsSafeDepositBoxOverviewAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}