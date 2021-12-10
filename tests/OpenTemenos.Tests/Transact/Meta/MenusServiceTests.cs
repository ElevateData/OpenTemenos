using Transact;
using Transact.Meta.Menus;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class MenusServiceTests : CredentialManagement
{
    private const string MenuId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetMainMenusAsync()
    {
        var result = _client.MenuService.GetMainMenusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMainMenuAsync()
    {
        var result = _client.MenuService.GetMainMenuAsync(MenuId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateMainMenuAsync()
    {
        var menuId = string.Empty;
        var payload = new CreateMainMenu();
        var result = _client.MenuService.CreateMainMenuAsync(menuId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMenusAsync()
    {
        var result = _client.MenuService.GetMenusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMenuAsync()
    {
        var result = _client.MenuService.GetMenuAsync(MenuId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}