using Transact;
using Transact.Reference.TransactionCodes;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class TransactionCodeServiceTests : CredentialManagement
{
    private const string TransactionCode = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetTransactionCodeAsync()
    {
        var result = _client.TransactionCodeService
            .GetTransactionCodeAsync(TransactionCode).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateTransactionCodeAsync()
    {
        var transactionCode = string.Empty;
        var payload = new TransactionCode();
        var result = _client.TransactionCodeService
            .CreateTransactionCodeAsync(transactionCode, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateTransactionCodeAsync()
    {
        var transactionCode = string.Empty;
        var payload = new TransactionCode();
        var result = _client.TransactionCodeService
            .UpdateTransactionCodeAsync(transactionCode, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionCodeListAsync()
    {
        var result = _client.TransactionCodeService
            .GetTransactionCodeListAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}