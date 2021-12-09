using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
public class RetailDepositProductBalancesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);


    [TestMethod]
    public void GetRetailDepositProductBalancesAsync()
    {
        var result = _client.RetailDepositProductBalanceService.GetRetailDepositProductBalancesAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}