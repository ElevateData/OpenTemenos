using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class SweepAccountDetailServiceTests : CredentialManagement
{
    private const string CreditAccount = "";
    private const string DebitAccount = "";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSweepCreditAccountDetailsAsync()
    {
        var result = _client.AccountSweepService.GetSweepCreditAccountDetailsAsync(CreditAccount).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetSweepDebitAccountDetailsAsync()
    {
        var result = _client.AccountSweepService.GetSweepDebitAccountDetailsAsync(DebitAccount).Result;
        Assert.IsNotNull(result.Data);
    }
}