using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;
using Transact.Reference.InterestBases;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class InterestBasesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string InterestBasisId = "A";

    [TestMethod]
    public void GetInterestBasesAsync()
    {
        var result = _client.InterestBasesService.GetInterestBasesAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"InterestBasisId: {result.Body.First().InterestBasisId}");
    }

    [TestMethod]
    public void GetInterestDayBasisDetailsAsync()
    {
        var result = _client.InterestBasesService.GetInterestDayBasisDetailsAsync(InterestBasisId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreateInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasis();
        var result = _client.InterestBasesService.CreateInterestDayBasisAsync(interestBasisId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdateInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasis();
        var result = _client.InterestBasesService.UpdateInterestDayBasisAsync(interestBasisId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteInterestDayBasisAsync()
    {
        var interestBasisId = string.Empty;
        var payload = new InterestDayBasisDelete();
        var result = _client.InterestBasesService.DeleteInterestDayBasisAsync(interestBasisId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}