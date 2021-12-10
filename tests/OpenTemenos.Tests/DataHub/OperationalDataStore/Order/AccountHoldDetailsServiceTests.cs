using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class AccountHoldDetailServiceTests : CredentialManagement
{
    private const string AccountId = "";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountHoldDetailsAsync()
    {
        var result = _client.UsModelBankCashTransactionService.GetAccountHoldDetailsAsync(AccountId).Result;
        Assert.IsNotNull(result.Data);
    }
}