using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Product;

[TestClass]
public class MarketingCatalogueServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

}