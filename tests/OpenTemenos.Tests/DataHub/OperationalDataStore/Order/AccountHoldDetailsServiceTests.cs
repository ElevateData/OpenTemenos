using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class AccountHoldDetailsServiceTests : CredentialManagement
{
    private const string AccountId = "";
    private readonly IOrderClient _client = new OrderClient(HttpClient);

    [TestMethod]
    public void GetAccountHoldDetailsAsync()
    {
        var result = _client.UsModelBankCashTransactionService.GetAccountHoldDetailsAsync(AccountId, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}