using OpenTemenos.DataHubs.AnalyticDataStore.Party.AllCustomerSegmentationDetails;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

public interface IPartyClient
{
    public IAllCustomerSegmentationDetailService CustomerSegmentationService { get; }
}