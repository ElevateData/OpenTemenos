using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class RetailLendingCustomerDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetRetailLendingCustomerDetailsAsync()
    {
        var result = _client.LendingCustomerBalanceService.GetRetailLendingCustomerDetailsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}