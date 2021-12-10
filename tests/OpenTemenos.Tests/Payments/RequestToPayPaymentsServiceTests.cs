using Payment.RequestToPayPayments;

namespace OpenTemenos.Tests.Payments;

[TestClass, TestCategory("Payments")]
public class RequestToPayPaymentServiceTests : CredentialManagement
{
    private const string CurrentState = "1";
    private const string RequestId = "1";
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePaymentRequestsAsync()
    {
        var payload = new PaymentRequests();
        var result = _client.RequestToPaymentService.CreatePaymentRequestsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPayersListAsync()
    {
        var result = _client.RequestToPaymentService.GetPayersListAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFullPaymentAsync()
    {
        var requestId = string.Empty;
        var payload = new FullPayment();
        var result = _client.RequestToPaymentService.UpdateFullPaymentAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePartialPaymentAsync()
    {
        var requestId = string.Empty;
        var payload = new PartialPayment();
        var result = _client.RequestToPaymentService.UpdatePartialPaymentAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDeclinePaymentAsync()
    {
        var requestId = string.Empty;
        var payload = new DeclinePayment();
        var result = _client.RequestToPaymentService.UpdateDeclinePaymentAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateNotesToRequestOrAsync()
    {
        var requestId = string.Empty;
        var payload = new NotesToRequestor();
        var result = _client.RequestToPaymentService.UpdateNotesToRequestorAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePaymentAmountAsync()
    {
        var requestId = string.Empty;
        var payload = new PaymentAmount();
        var result = _client.RequestToPaymentService.UpdatePaymentAmountAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDeclineAndBlockAsync()
    {
        var requestId = string.Empty;
        var payload = new DeclineAndBlock();
        var result = _client.RequestToPaymentService.UpdateDeclineAndBlockAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateNotesToPayerAsync()
    {
        var requestId = string.Empty;
        var payload = new NotesToPayer();
        var result = _client.RequestToPaymentService.UpdateNotesToPayerAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDateExtensionAsync()
    {
        var requestId = string.Empty;
        var payload = new DateExtension();
        var result = _client.RequestToPaymentService.UpdateDateExtensionAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetRequestorsDateExtensionAsync()
    {
        var result = _client.RequestToPaymentService.GetRequestorsDateExtensionAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetRequestorsOutwardRequestAsync()
    {
        var result = _client.RequestToPaymentService.GetRequestorsOutwardRequestAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPayersStatusAsync()
    {
        var result = _client.RequestToPaymentService.GetPayersStatusAsync(CurrentState)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPayerListWithExtensionGrantedAsync()
    {
        var result = _client.RequestToPaymentService.GetPayerListWithExtensionGrantedAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateGrantExtensionAsync()
    {
        var requestId = string.Empty;
        var payload = new GrantExtension();
        var result = _client.RequestToPaymentService.UpdateGrantExtensionAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPayersListWithExtensionDeclinedAsync()
    {
        var result = _client.RequestToPaymentService.GetPayersListWithExtensionDeclinedAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDeclineExtensionAsync()
    {
        var requestId = string.Empty;
        var payload = new DeclineExtension();
        var result = _client.RequestToPaymentService.UpdateDeclineExtensionAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetApiPendingAckAsync()
    {
        var result = _client.RequestToPaymentService.GetApiPendingAckAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateBillerAcknowledgmentsAsync()
    {
        var requestId = string.Empty;
        var payload = new BillerAcknowledgements();
        var result = _client.RequestToPaymentService.UpdateBillerAcknowledgementsAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutwardErrorsAsync()
    {
        var result = _client.RequestToPaymentService.GetOutwardErrorsAsync(RequestId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePayUKPaymentRequestsAsync()
    {
        var payload = new PayUKPaymentRequests();
        var result = _client.RequestToPaymentService.CreatePayUKPaymentRequestsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendPayUKPaymentForRepositoryAsync()
    {
        var requestId = string.Empty;
        var payload = new PayUKPaymentRequests();
        var result = _client.RequestToPaymentService.AmendPayUKPaymentForRepositoryAsync(requestId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}