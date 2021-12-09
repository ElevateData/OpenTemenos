using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class CustomerLoanDelinquency30DaysServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetCustomerLoanDelinquency30DaysAsync()
    {
        var result = _client.CustomerLoanDelinquencyService.GetCustomerLoanDelinquency30DaysAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}