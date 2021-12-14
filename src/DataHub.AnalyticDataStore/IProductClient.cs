using OpenTemenos.DataHubs.AnalyticDataStore.Product.CorporateLendingProductBalances;
using OpenTemenos.DataHubs.AnalyticDataStore.Product.RetailDepositProductBalances;
using OpenTemenos.DataHubs.AnalyticDataStore.Product.RetailLendingProductBalances;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

public interface IProductClient
{
    public ICorporateLendingProductBalanceService CorporateLendingProductService { get; }
    public IRetailDepositProductBalanceService RetailDepositProductBalanceService { get; }
    public IRetailLendingProductBalanceService RetailLendingProductBalanceService { get; }
}