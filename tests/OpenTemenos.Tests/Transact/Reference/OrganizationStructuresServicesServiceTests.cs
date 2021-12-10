﻿using Transact;
using Transact.Reference.OrganizationStructuresServices;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class OrganizationStructuresServicesServiceTests : CredentialManagement
{
    private const string OrganizationId = "";
    private const string BranchId = "";
    private const string LineOfBusinessId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetOrganizationHierarchyAsync()
    {
        var result = _client.OrganizationStructuresServicesService
            .GetOrganizationHierarchyAsync(OrganizationId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateOrganizationHierarchyAsync()
    {
        var organizationId = string.Empty;
        var payload = new OrganizationHierarchy();
        var result = _client.OrganizationStructuresServicesService
            .CreateOrganizationHierarchyAsync(organizationId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateOrganizationHierarchyAsync()
    {
        var organizationId = string.Empty;
        var payload = new OrganizationHierarchy();
        var result = _client.OrganizationStructuresServicesService
            .UpdateOrganizationHierarchyAsync(organizationId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetChildOrganizationsAsync()
    {
        var result = _client.OrganizationStructuresServicesService
            .GetChildOrganizationsAsync(OrganizationId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetOrganizationBranchNameAsync()
    {
        var result = _client.OrganizationStructuresServicesService
            .GetOrganizationBranchNameAsync(BranchId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetLineOfBusinessNameAsync()
    {
        var result = _client.OrganizationStructuresServicesService
            .GetLineOfBusinessNameAsync(LineOfBusinessId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}