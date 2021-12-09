using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class GuaranteeDetailsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetGuaranteeIssuanceRequestsAsync()
    {
        var result = _client.GuaranteeDetailService.GetGuaranteeIssuanceRequestsAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}