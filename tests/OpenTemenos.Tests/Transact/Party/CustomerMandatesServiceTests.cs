using Transact;
using Transact.Party.CustomerMandates;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerMandatesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateMandateAsync()
    {
        var customerId = string.Empty;
        var payload = new Mandate();
        var result = _client.CustomerMandatesService.UpdateMandateAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateMandateParameterAsync()
    {
        var applicationId = string.Empty;
        var payload = new MandateParameter();
        var result = _client.CustomerMandatesService.UpdateMandateParameterAsync(applicationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSignatoryGroupAsync()
    {
        var signatoryGroupId = string.Empty;
        var payload = new SignatoryGroup();
        var result = _client.CustomerMandatesService.UpdateSignatoryGroupAsync(signatoryGroupId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void SimulateSignatoryMandateProcessingAsync()
    {
        var transactionSimulationId = string.Empty;
        var result = _client.CustomerMandatesService.SimulateSignatoryMandateProcessingAsync(transactionSimulationId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}