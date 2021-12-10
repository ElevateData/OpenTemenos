using Transact;
using Transact.Reference.OrganizationStructures;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class OrganizationStructureServiceTests : CredentialManagement
{
    private const string OrganizationId = "";
    private const string BranchId = "";
    private const string LineOfBusinessId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetOrganizationHierarchyAsync()
    {
        var result = _client.OrganizationStructureService
            .GetOrganizationHierarchyAsync(OrganizationId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateOrganizationHierarchyAsync()
    {
        var organizationId = string.Empty;
        var payload = new OrganizationHierarchy();
        var result = _client.OrganizationStructureService
            .CreateOrganizationHierarchyAsync(organizationId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateOrganizationHierarchyAsync()
    {
        var organizationId = string.Empty;
        var payload = new OrganizationHierarchy();
        var result = _client.OrganizationStructureService
            .UpdateOrganizationHierarchyAsync(organizationId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetChildOrganizationsAsync()
    {
        var result = _client.OrganizationStructureService
            .GetChildOrganizationsAsync(OrganizationId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetOrganizationBranchNameAsync()
    {
        var result = _client.OrganizationStructureService
            .GetOrganizationBranchNameAsync(BranchId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetLineOfBusinessNameAsync()
    {
        var result = _client.OrganizationStructureService
            .GetLineOfBusinessNameAsync(LineOfBusinessId).Result;
        Assert.IsNotNull(result.Body);
    }
}