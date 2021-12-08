using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCustomerRatingServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsCustomerRatingListAsync()
    {
        var result = _client.UsCustomerRatingService.GetUsCustomerRatinglistAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"RatingIds: {string.Join(",", result.Body.First().RatingIds!)}");
    }
}