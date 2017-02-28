using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHandin2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandin2.Tests
{
    [TestClass()]
    public class ReimbursementTests
    {
        Reimbursement r;
        [TestInitialize]
        public void beforeTest()
        {
            r = new Reimbursement();
        }
        

        [TestMethod()]
        public void DeductableMetDoctorsVisit()
        {
            Assert.AreEqual(r.reimbursementPercentage(true, "d"), 50);
        }

        [TestMethod()]
        public void DeductableNotMetDoctorsVisit()
        {
            Assert.AreEqual(r.reimbursementPercentage(false, "d"), 0);
        }

        [TestMethod()]
        public void DeductableMetHospitalVisit()
        {
            Assert.AreEqual(r.reimbursementPercentage(true, "h"), 80);
        }

        [TestMethod()]
        public void DeductableNotMetHospitalVisit()
        {
            Assert.AreEqual(r.reimbursementPercentage(false, "h"), 0);
        }

    }
}