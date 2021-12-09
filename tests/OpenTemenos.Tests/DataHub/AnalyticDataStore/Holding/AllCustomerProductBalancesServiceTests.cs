using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;


[TestClass]
public class AllCustomerProductBalancesServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetAllCustomerProductBalancesAsync()
    {
        var result = _client.CustomerProductBalanceService
            .GetAllCustomerProductBalancesAsync(null, null)
            .Result;
        Assert.IsNotNull(result.Data);
    }
}