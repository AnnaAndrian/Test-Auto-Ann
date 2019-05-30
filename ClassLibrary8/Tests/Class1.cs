using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary8.Tests
{
    class FirstTEst
    {
        [Test]
        public void FirstTest()
        {
           Assert.That(1, Is.EqualTo(1));

        }
    }
}