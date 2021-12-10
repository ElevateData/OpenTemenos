using Transact;
using Transact.Party.CustomersDocuments;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomersDocumentsServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string CustomerDocumentId = "1";
    private const string ImageId = "2";
    private const string ImageReference = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetDocumentImageAsync()
    {
        var result = _client.CustomersDocumentsService.GetDocumentImageAsync(CustomerId, ImageId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDocumentImageAsync()
    {
        var customerId = string.Empty;
        var imageId = string.Empty;
        var payload = new DocumentImage();
        var result = _client.CustomersDocumentsService.UpdateDocumentImageAsync(customerId, imageId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerImagesAsync()
    {
        var result = _client.CustomersDocumentsService.GetCustomerImagesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateDocumentImageAsync()
    {
        var customerId = string.Empty;
        var payload = new DocumentImage();
        var result = _client.CustomersDocumentsService.CreateDocumentImageAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerDocumentAsync()
    {
        var result = _client.CustomersDocumentsService.GetCustomerDocumentAsync(CustomerDocumentId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCustomerDocumentAsync()
    {
        var customerDocumentId = string.Empty;
        var payload = new CustomerDocument();
        var result = _client.CustomersDocumentsService.CreateCustomerDocumentAsync(customerDocumentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AmendCustomerDocumentAsync()
    {
        var customerDocumentId = string.Empty;
        var payload = new CustomerDocument();
        var result = _client.CustomersDocumentsService.AmendCustomerDocumentAsync(customerDocumentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCustomerDocumentAsync()
    {
        var customerDocumentId = string.Empty;
        var payload = new CustomerDocumentDelete();
        var result = _client.CustomersDocumentsService.DeleteCustomerDocumentAsync(customerDocumentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerDocumentsAsync()
    {
        var result = _client.CustomersDocumentsService.GetCustomerDocumentsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetDocumentsLocationAsync()
    {
        var result = _client.CustomersDocumentsService.GetDocumentsLocationAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetDocumentAndImagesAsync()
    {
        var result = _client.CustomersDocumentsService.GetDocumentandImagesAsync(ImageReference)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateProfilePictureUploadAsync()
    {
        var uploadId = string.Empty;
        var payload = new ProfilePictureUpload();
        var result = _client.CustomersDocumentsService.CreateProfilePictureUploadAsync(uploadId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateProfilePictureUploadAsync()
    {
        var uploadId = string.Empty;
        var payload = new ProfilePictureUpload();
        var result = _client.CustomersDocumentsService.UpdateProfilePictureUploadAsync(uploadId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteProfilePictureUploadAsync()
    {
        var uploadId = string.Empty;
        var payload = new ProfilePictureUploadDelete();
        var result = _client.CustomersDocumentsService.DeleteProfilePictureUploadAsync(uploadId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateDocumentAndImageAsync()
    {
        var payload = new DocumentandImage();
        var result = _client.CustomersDocumentsService.CreateDocumentandImageAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDocumentAndImageAsync()
    {
        var documentId = string.Empty;
        var payload = new DocumentandImage();
        var result = _client.CustomersDocumentsService.UpdateDocumentandImageAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteDocumentAndImageAsync()
    {
        var documentId = string.Empty;
        var payload = new DocumentandImageDelete();
        var result = _client.CustomersDocumentsService.DeleteDocumentandImageAsync(documentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}