using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class RetailDepositsCustomerDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetRetailDepositsCustomerDetailsAsync()
    {
        var result = _client.DepositCustomerBalanceService.GetRetailDepositsCustomerDetailsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}