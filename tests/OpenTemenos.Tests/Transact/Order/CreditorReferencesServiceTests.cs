using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class CreditorReferenceServiceTests : CredentialManagement
{
    private const string CreditorReference = "";
    private const string GenerateOrValidateOption = "VALIDATE";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountTransfersAsync()
    {
        var result = _client.CreditorReferenceService
            .GetStructuredCreditorReferenceAsync(CreditorReference, GenerateOrValidateOption)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}