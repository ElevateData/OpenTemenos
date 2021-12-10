using Transact;
using Transact.Order.AccountTransfers;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class AccountTransferServiceTests : CredentialManagement
{
    private const string BulkTransferId = "1";
    private const string CreditAccountId = "1";
    private const string DebitAccountId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountTransfersAsync()
    {
        var result = _client.AccountFundTransferService.GetAccountTransfersAsync(DebitAccountId, CreditAccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetBulkTransfersAsync()
    {
        var result = _client.AccountFundTransferService.GetBulkTransfersAsync(BulkTransferId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateInwardTransferAsync()
    {
        var payload = new InwardTransfer();
        var result = _client.AccountFundTransferService.CreateInwardTransferAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateInwardTransferAsync()
    {
        var fundsTransferId = string.Empty;
        var payload = new InwardTransfer();
        var result = _client.AccountFundTransferService.UpdateInwardTransferAsync(fundsTransferId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetInwardTransfersAsync()
    {
        var result = _client.AccountFundTransferService.GetInwardTransfersAsync(DebitAccountId, CreditAccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateOutwardTransferAsync()
    {
        var payload = new OutwardTransfer();
        var result = _client.AccountFundTransferService.CreateOutwardTransferAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateOutwardTransferAsync()
    {
        var fundsTransferId = string.Empty;
        var payload = new OutwardTransfer();
        var result = _client.AccountFundTransferService.UpdateOutwardTransferAsync(fundsTransferId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutwardTransfersAsync()
    {
        var result = _client.AccountFundTransferService.GetOutwardTransfersAsync(DebitAccountId, CreditAccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAccountTransferAsync()
    {
        var payload = new AccountTransfer();
        var result = _client.AccountFundTransferService.CreateAccountTransferAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountTransferAsync()
    {
        var fundsTransferId = string.Empty;
        var payload = new AccountTransfer();
        var result = _client.AccountFundTransferService.UpdateAccountTransferAsync(fundsTransferId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAccountTransferAsync()
    {
        var fundsTransferId = string.Empty;
        var payload = new AccountTransferDelete();
        var result = _client.AccountFundTransferService.DeleteAccountTransferAsync(fundsTransferId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}