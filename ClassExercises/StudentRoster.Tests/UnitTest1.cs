using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentRoster.Tests
{
    [TestClass]
    public class RosterTest
    {
        [TestMethod]
        public void StudentShouldNotBeNull()
        {
            Roster r = new Roster();

            Assert.IsNotNull(r.Students);

        }
        [TestMethod]
        public void Add_Adds_Student_To_Roster()
        {
            Roster r = new Roster();

            Student s1 = new Student()
            {
                Name = "James",
                Gender = "Male"
            };

            Student s2 = new Student()
            {
                Name = "Jane",
                Gender = "Female"
            };

            Assert.AreEqual(0, r.Students.Count);

            r.Add(s1);

            Assert.AreEqual(1, r.Students.Count);
        }
    }
}
