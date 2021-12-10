using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class CustomerLoanDelinquency30DaysServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetCustomerLoanDelinquency30DaysAsync()
    {
        var result = _client.CustomerLoanDelinquencyService.GetCustomerLoanDelinquency30DaysAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}