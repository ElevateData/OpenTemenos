using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AccountTransactionDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);

    [TestMethod]
    public void GetAccountTransactionDetailsAsync()
    {
        var result = _client.AccountTransactionDetailService
            .GetAccountTransactionDetailsAsync(null, null)
            .Result;
        Assert.IsNotNull(result.Data);
    }
}
