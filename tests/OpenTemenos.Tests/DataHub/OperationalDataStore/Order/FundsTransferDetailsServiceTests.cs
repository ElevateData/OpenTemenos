using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class FundsTransferDetailsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
    private const string InwardPayType = "";
    private const string DebitAccountId = "";
    private const string CreditAccountId = "";

    [TestMethod]
    public void GetBulkTransfersAsync()
    {
        var result = _client.FundsTransferDetailService.GetBulkTransfersAsync(InwardPayType).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAccountTransfersAsync()
    {
        var result = _client.FundsTransferDetailService.GetAccountTransfersAsync(DebitAccountId, CreditAccountId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetInwardFundsTransferAsync()
    {
        var result = _client.FundsTransferDetailService.GetInwardFundsTransferAsync(DebitAccountId, CreditAccountId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetOutwardFundsTransferAsync()
    {
        var result = _client.FundsTransferDetailService.GetOutwardFundsTransferAsync(DebitAccountId, CreditAccountId).Result;
        Assert.IsNotNull(result.Data);
    }
}