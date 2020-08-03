using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Activity.Profile;
using Xunit;

namespace Activity1.Tests
{
    public class ComputeAgeTests
    {
        [Fact]
        public void TestAgeEugene()
        {
            var eugene = new PlayerProfile("Eugene", PlayerProfile.MALE, new DateTime(1990, 9, 13));

            Assert.Equal(29, eugene.ComputeAge());
        }

        [Fact]
        public void TestAgeJohn()
        {
            var john = new PlayerProfile("John", PlayerProfile.FEMALE, new DateTime(1990, 2, 1));

            Assert.Equal(30, john.ComputeAge());
        }

        [Fact]
        public void TestAgeTony()
        {
            var tony = new PlayerProfile("Tony", PlayerProfile.MALE, new DateTime(1990, 7, 30));

            Assert.Equal(30, tony.ComputeAge());
        }

        [Fact]
        public void TestAgeZero()
        {
            var now = new PlayerProfile("The Zero", PlayerProfile.MALE, DateTime.Now);

            Assert.Equal(0, now.ComputeAge());
        }

        [Fact]
        public void TestAgeNadja()
        {
            var nadja = new PlayerProfile("Nadja", PlayerProfile.FEMALE, new DateTime(1990, 7, 22));

            Assert.Equal(30, nadja.ComputeAge());
        }

        [Fact]
        public void TestAgeBob()
        {
            var bob = new PlayerProfile("Bob", PlayerProfile.MALE, new DateTime(1990, 3, 1));

            Assert.Equal(30, bob.ComputeAge());
        }

        [Fact]
        public void TestAgeChris()
        {
            var chris = new PlayerProfile("Chris", PlayerProfile.MALE, new DateTime(1990, 3, 5));

            Assert.Equal(30, chris.ComputeAge());
        }
    }
}
