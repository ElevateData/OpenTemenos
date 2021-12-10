using DataHub.AnalyticDataStore.Party.AllCustomerSegmentationDetails;

namespace DataHub.AnalyticDataStore;

public interface IPartyClient
{
    public IAllCustomerSegmentationDetailService CustomerSegmentationService { get; }
}
