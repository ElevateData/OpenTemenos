using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class USCustomerRatingListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUSCustomerRatingListAsync()
    {
        var result = _client.UsModelBankCustomerRiskRatingService.GetUSCustomerRatingListAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}