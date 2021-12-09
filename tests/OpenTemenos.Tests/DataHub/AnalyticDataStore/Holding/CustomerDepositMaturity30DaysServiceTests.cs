using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class CustomerDepositMaturity30DaysServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetCustomerDepositMaturity30DaysAsync()
    {
        var result = _client.CustomerDepositService.GetCustomerDepositMaturity30DaysAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}