using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class FundsTransferDetailServiceTests : CredentialManagement
{
    private const string InwardPayType = "";
    private const string DebitAccountId = "";
    private const string CreditAccountId = "";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBulkTransfersAsync()
    {
        var result = _client.FundsTransferDetailService.GetBulkTransfersAsync(InwardPayType).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetAccountTransfersAsync()
    {
        var result = _client.FundsTransferDetailService.GetAccountTransfersAsync(DebitAccountId, CreditAccountId)
            .Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetInwardFundsTransferAsync()
    {
        var result = _client.FundsTransferDetailService.GetInwardFundsTransferAsync(DebitAccountId, CreditAccountId)
            .Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetOutwardFundsTransferAsync()
    {
        var result = _client.FundsTransferDetailService.GetOutwardFundsTransferAsync(DebitAccountId, CreditAccountId)
            .Result;
        Assert.IsNotNull(result.Data);
    }
}