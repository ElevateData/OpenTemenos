using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using FundAdministration.GlobalInvestor.Product.Securities;
using FundAdministration.GlobalInvestor.Product.SecurityDescs;
using FundAdministration.GlobalInvestor.Product.ShareValues;

namespace FundAdministration.GlobalInvestor;

public interface IMasterFund
{
    //public IMasterFundService MasterFundService { get; }
    public ISecurityDescService SecurityDescriptionService { get; }
    public IShareValueService ShareValueService { get; }
    public IMinDivPaymentService MinDividendPaymentService { get; }
    public ISecurityService SecurityService { get; }
}
