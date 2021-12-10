using Transact;
using Transact.Reference.InterestBases;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class InterestBaseServiceTests : CredentialManagement
{
    private const string InterestBasisId = "A";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetInterestBasesAsync()
    {
        var result = _client.InterestBaseService
            .GetInterestBasesAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetInterestDayBasisDetailsAsync()
    {
        var result = _client.InterestBaseService
            .GetInterestDayBasisDetailsAsync(InterestBasisId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasis();
        var result = _client.InterestBaseService
            .CreateInterestDayBasisAsync(interestBasisId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasis();
        var result = _client.InterestBaseService
            .UpdateInterestDayBasisAsync(interestBasisId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasisDelete();
        var result = _client.InterestBaseService
            .DeleteInterestDayBasisAsync(interestBasisId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}