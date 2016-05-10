using System;
using System.Configuration;
using IntToEnum.Enum;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CastIntToPaymentStatusShould
    {
        [Test]
        public void ReturnSubmittedStatus_WhenCastToEnum_GivenAnIntegerValueOfOne()
        {
            var statusAsInt = 1;
            PaymentStatus resultOfCast = (PaymentStatus) statusAsInt;

            Assert.AreEqual(PaymentStatus.Submitted, resultOfCast);
        }

        [Test]
        public void ReturnPaymentStatusType_WhenCastToEnum_GivenInvalidEnumValue()
        {
            var statusAsInt = 5;
            PaymentStatus resultOfCast = (PaymentStatus)statusAsInt;

            Assert.IsInstanceOf<PaymentStatus>(resultOfCast);
        }
    }
}
