using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class AllCustomerTransactionCountServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetAllCustomerTransactionCountAsync()
    {
        var result = _client.CustomerTransactionClassificationService.GetAllCustomerTransactionCountAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}