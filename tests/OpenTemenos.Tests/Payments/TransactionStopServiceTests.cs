using Payment.TransactionStops;

namespace OpenTemenos.Tests.Payments;

[TestClass, TestCategory("Payments")]
public class TransactionStopServiceTests : CredentialManagement
{
    private const string TransactionStopId = "1";
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateTransactionStopAsync()
    {
        var payload = new TransactionStop();
        var result = _client.TransactionStopService.CreateTransactionStopAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetStopInstructionsAsync()
    {
        var result = _client.TransactionStopService.GetStopInstructionsAsync(TransactionStopId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateTransactionStopAsync()
    {
        var transactionStopId = string.Empty;
        var payload = new TransactionStop();
        var result = _client.TransactionStopService.UpdateTransactionStopAsync(transactionStopId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetInvestigationItemsAsync()
    {
        var result = _client.TransactionStopService.GetInvestigationItemsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateTransactionStopInvestigationsAsync()
    {
        var transactionStopId = string.Empty;
        var payload = new TransactionStopInvestigations();
        var result = _client.TransactionStopService.UpdateTransactionStopInvestigationsAsync(transactionStopId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}