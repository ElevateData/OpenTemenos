using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Enterprise
{
    [TestClass]
    public class EnterpriseProductPricingServiceTests : CredentialManagement
    {
        private readonly IEnterpriseClient _client = new EnterpriseClient(HttpClient);
        private readonly string _baseContractReference = string.Empty;
        private readonly string _productId = string.Empty;
        private readonly string _arrangementId = string.Empty;
        private readonly string _packageId = string.Empty;
        private readonly string _partyId = string.Empty;

        [TestMethod]
        public void GetPackageStatementAsync()
        {
            var result = _client.EnterpriseProductPricingService
                .GetPackageStatementAsync(_baseContractReference, null, null, null, null, null, null, null, null, null, null)
                .Result;
            Assert.IsNotNull(result.Body);
        }

        [TestMethod]
        public void GetActivityChargeAmountAsync()
        {
            var result = _client.EnterpriseProductPricingService.GetActivityChargeAmountAsync(_baseContractReference, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetPeriodicChargesAmountAsync()
        {
            var result = _client.EnterpriseProductPricingService.GetPeriodicChargesAmountAsync(_baseContractReference, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetInterestRateAsync()
        {
            var result = _client.EnterpriseProductPricingService.GetInterestRateAsync(_baseContractReference, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetEligibilityDetailsAsync()
        {
            var result = _client.EnterpriseProductPricingService
                .GetEligibilityDetailsAsync(_productId, null, null, null, null, null, null, null, null, null, null, null)
                .Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetTransactionPricingRequestAsync()
        {
            var result = _client.EnterpriseProductPricingService.GetTransactionPricingRequestAsync(_baseContractReference, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetNewActivityPricingAsync()
        {
            var result = _client.EnterpriseProductPricingService.GetNewActivityPricingAsync(_productId, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetPricingDetailsEventListAsync()
        {
            var result = _client.EnterpriseProductPricingService
                .GetPricingDetailsEventListAsync(_arrangementId, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetPackagePeriodicPricingAsync()
        {
            var result = _client.EnterpriseProductPricingService
                .GetPackagePeriodicPricingAsync(_packageId, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetPackageDetailsAsync()
        {
            var result = _client.EnterpriseProductPricingService
                .GetPackageDetailsAsync(_packageId, null, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetCustomerHeldContractsAsync()
        {
            var result = _client.EnterpriseProductPricingService
                .GetCustomerHeldContractsAsync(_partyId, null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
        [TestMethod]
        public void GetContractEventListAsync()
        {
            var result = _client.EnterpriseProductPricingService.GetContractEventListAsync(_baseContractReference, null, null, null, null,
                null, null, null, null, null, null, null, null).Result;
            Assert.IsNotNull(result.Body);
        }
    }
}