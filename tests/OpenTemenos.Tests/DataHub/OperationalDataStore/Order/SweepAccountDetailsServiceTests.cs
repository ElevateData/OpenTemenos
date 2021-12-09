using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class SweepAccountDetailsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
    private const string CreditAccount = "";
    private const string DebitAccount = "";

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