using NUnit.Framework;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core.Tests
{
    public class VehicleStatusProcessorTests
    {
        private TransportationCompanyRequest _transportationCompanyRequest;

        [SetUp]
        public void Setup()
        {
            _transportationCompanyRequest = new TransportationCompanyRequest();
        }

        [Test]
        public void ShouldReturnACompanyObject()
        {
             

        }
    }
}
