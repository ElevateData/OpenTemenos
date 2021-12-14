using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Meta.Menus;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
[TestCategory("Transact")]
public class MenuServiceTests : CredentialManagement
{
    private const string MenuId = "1";
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetMainMenusAsync()
    {
        var result = _client.MenuService.GetMainMenusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMainMenuAsync()
    {
        var result = _client.MenuService.GetMainMenuAsync(MenuId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
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
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMenusAsync()
    {
        var result = _client.MenuService.GetMenusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMenuAsync()
    {
        var result = _client.MenuService.GetMenuAsync(MenuId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}