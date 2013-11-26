using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tritest = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(tritest.isScalene());
            Assert.IsFalse(tritest.isIsosceles());
            Assert.IsFalse(tritest.isEquilateral());
        }

        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tritest = new Triangle(3.0, 3.0, 5.0);
            Assert.IsTrue(tritest.isIsosceles());
            Assert.IsFalse(tritest.isScalene());
            Assert.IsFalse(tritest.isEquilateral());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tritest = new Triangle(5.0, 5.0, 5.0);
            Assert.IsTrue(tritest.isEquilateral());
            Assert.IsTrue(tritest.isScalene());
            Assert.IsFalse(tritest.isIsosceles());
        }

        [TestMethod]
        public void ConstTest1()
        {
            double[] arr = new double[3];
            arr[0] = 3.0;
            arr[1] = 3.0;
            arr[2] = 5.0;
            Triangle tritest = new Triangle(arr);
            Assert.IsTrue(tritest.isIsosceles());
            Assert.IsFalse(tritest.isScalene());
            Assert.IsFalse(tritest.isEquilateral());
        }

        [TestMethod]
        public void ConstTest2()
        {
            double[] arr = new double[3];
            arr[0] = 3.0;
            arr[1] = 3.0;
            arr[2] = 5.0;
            Triangle tritest = new Triangle(arr);
            Assert.IsTrue(tritest.isIsosceles());
            Assert.IsFalse(tritest.isScalene());
            Assert.IsFalse(tritest.isEquilateral());
        }

    }
}
