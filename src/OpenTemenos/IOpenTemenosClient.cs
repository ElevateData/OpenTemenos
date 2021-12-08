namespace OpenTemenos;

public interface IOpenTemenosClient
{
    public IDataHub DataHub { get; }
    [Obsolete]
    public IFinancialCrimeMitigation FinancialCrimeMitigation { get; }
    public ITransact Transact { get; }
    public IFundAdministration FundAdministration { get; }
    [Obsolete]
    public IPortfolioManagement PortfolioManagement { get; }
    public IPayment Payment { get; }
}