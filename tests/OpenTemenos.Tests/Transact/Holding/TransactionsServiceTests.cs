using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class TransactionsServiceTests : CredentialManagement
{
    private const string TransactionId = "";
    private const string TransactionReferenceId = "FX2109691941";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetTransactionDetailsAsync()
    {
        var result = _client.TransactionService.GetTransactionDetailsAsync(TransactionId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetStatementForTransactionAsync()
    {
        var result = _client.TransactionService.GetStatementForTransactionAsync(TransactionReferenceId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAccountTransactionsAsync()
    {
        var result = _client.TransactionService.GetAccountTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}