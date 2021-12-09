using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class ProductTransactionMetricsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetProductTransactionMetricsAsync()
    {
        var result = _client.ProductTransactionService.GetProductTransactionMetricsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}