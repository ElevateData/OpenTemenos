using OpenTemenos.Payments;

namespace OpenTemenos;

public interface IOpenTemenosClient
{
    public IDataHub DataHub { get; }
    [Obsolete]
    public IFinancialCrimeMitigation FinancialCrimeMitigation { get; }
    public IFundAdministration FundAdministration { get; }
    [Obsolete]
    public IPortfolioManagement PortfolioManagement { get; }
    public IPaymentClient Payment { get; }
}