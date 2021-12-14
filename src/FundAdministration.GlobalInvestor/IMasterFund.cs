using OpenTemenos.FundAdministrations.GlobalInvestor.Product.MinDivPayments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.Securities;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SecurityDescs;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ShareValues;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public interface IMasterFund
{
    //public IMasterFundService MasterFundService { get; }
    public ISecurityDescService SecurityDescriptionService { get; }
    public IShareValueService ShareValueService { get; }
    public IMinDivPaymentService MinDividendPaymentService { get; }
    public ISecurityService SecurityService { get; }
}