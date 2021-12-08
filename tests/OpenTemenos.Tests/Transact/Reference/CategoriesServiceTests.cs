using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;
using Transact.Reference.Categories;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CategoriesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string CategoryId = "1000";

    [TestMethod]
    public void GetCategoriesAsync()
    {
        var result = _client.CategoriesService
            .GetCategoriesAsync(null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CategoryId: {result.Body.First().CategoryId}");
    }
    [TestMethod]
    public void GetCategoryDetailsAsync()
    {
        var result = _client.CategoriesService.GetCategoryDetailsAsync(CategoryId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("POST method")]
    public void CreateCategoryDetailsAsync()
    {
        var categoryId = string.Empty;
        var payload = new CategoryDetails();
        var result = _client.CategoriesService.CreateCategoryDetailsAsync(categoryId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod, Ignore("PUT method")]
    public void UpdateCategoryDetailsAsync()
    {
        var categoryId = string.Empty;
        var payload = new CategoryDetails();
        var result = _client.CategoriesService.UpdateCategoryDetailsAsync(categoryId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}