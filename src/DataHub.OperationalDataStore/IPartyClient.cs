using DataHub.OperationalDataStore.Party.CustomerDetails;
using DataHub.OperationalDataStore.Party.ExternalUserDetails;
using DataHub.OperationalDataStore.Party.ParticipantList;
using DataHub.OperationalDataStore.Party.UsCustomerDetails;

namespace DataHub.OperationalDataStore;

public interface IPartyClient
{
    public ICustomerDetailsService CustomerDetailService { get; }
    public IExternalUserDetailsService ExternalUserDetailService { get; }
    public IParticipantListService ParticipantListService { get; }
    public IUsCustomerDetailsService UsModelBankCustomerDetailService { get; }
}
