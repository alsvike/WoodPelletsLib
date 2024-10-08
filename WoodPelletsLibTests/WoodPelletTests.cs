using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodPelletsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletsLib.Tests
{
    [TestClass()]
    public class WoodPelletTests
    {

        [TestMethod()]
        public void ValidateBrandTest()
        {
            //Arrange
            WoodPellet woodPellet = new WoodPellet(1, "BioWood", 4995, 4);

            //Act
            woodPellet.ValidateBrand();
        }

        [TestMethod()]
        public void ValidateQualityTest()
        {
            //Arrange
            WoodPellet woodPellet = new WoodPellet(1, "BioWood", 4995, 4);

            //Act
            woodPellet.ValidateQuality();
        }
    }
}