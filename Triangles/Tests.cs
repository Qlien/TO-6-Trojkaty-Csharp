using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Triangle
{
	public class Tests
	{

    	[SetUp]
    	public void SetUp()
    	{
    	}

    	[TearDown]
    	public void TearDown()
    	{
        	GC.Collect();
    	}


        [Test]
        public void is_equilateral()
        {
            Triangle t = new Triangle(6, 6, 6);
            Assert.True(t.is_equilateral());
        }

        [Test]
        public void is_data_right()
        {
            Triangle t = new Triangle(17777, 6, 6);
            Assert.False(t.is_data_right());
        }

        [Test]
        public void is_isosceles_and_data()
        {
            Triangle t = new Triangle(17777, 6, 6);
            Assert.True(t.is_data_right());
            Assert.True(t.is_isosceles());
        }

        [Test]
        public void is_right()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.True(t.is_right());
        }

        [Test]
        public void is_scalene()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.True(t.is_scalene());
        }

	}
}
