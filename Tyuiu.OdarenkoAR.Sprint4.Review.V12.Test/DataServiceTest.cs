﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint4.Review.V12.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Review.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "658932125478";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
