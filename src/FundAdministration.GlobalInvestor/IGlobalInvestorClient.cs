namespace FundAdministration.GlobalInvestor;

public interface IGlobalInvestorClient
{
    public IOrderClient OrderClient { get; }
    public IPartyClient PartyClient { get; }
    public IProductClient ProductClient { get; }
    public IReferenceClient ReferenceClient { get; }
    public ISystemClient SystemClient { get; }
}