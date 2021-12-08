using DataHub.AnalyticDataStore.Product.CorporateLendingProductBalances;
using DataHub.AnalyticDataStore.Product.CorporateLendingProductBalances;
using DataHub.AnalyticDataStore.Product.RetailDepositProductBalances;
using DataHub.AnalyticDataStore.Product.RetailDepositProductBalances;
using DataHub.AnalyticDataStore.Product.RetailLendingProductBalances;
using DataHub.AnalyticDataStore.Product.RetailLendingProductBalances;

namespace DataHub.AnalyticDataStore;

public interface IProductClient
{
    public ICorporateLendingProductBalancesService CorporateLendingProductService { get; }
    public IRetailDepositProductBalancesService RetailDepositProductBalanceService { get; }
    public IRetailLendingProductBalancesService RetailLendingProductBalanceService { get; }
}
