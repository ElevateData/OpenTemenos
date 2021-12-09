using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class AccountHoldDetailsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
    private const string AccountId = "";

    [TestMethod]
    public void GetAccountHoldDetailsAsync()
    {
        var result = _client.UsModelBankCashTransactionService.GetAccountHoldDetailsAsync(AccountId, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}