using DataHub.AnalyticDataStore.Product.CorporateLendingProductBalances;
using DataHub.AnalyticDataStore.Product.RetailDepositProductBalances;
using DataHub.AnalyticDataStore.Product.RetailLendingProductBalances;

namespace DataHub.AnalyticDataStore;

public interface IProductClient
{
    public ICorporateLendingProductBalanceService CorporateLendingProductService { get; }
    public IRetailDepositProductBalanceService RetailDepositProductBalanceService { get; }
    public IRetailLendingProductBalanceService RetailLendingProductBalanceService { get; }
}
