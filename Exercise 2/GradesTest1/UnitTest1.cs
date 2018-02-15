using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradesTest
{
    [TestClass]
    public class UnitTest
    {
        [TestInitialize]
        public void Init()      //Initializes the DataSource from GradesPrototype
        {
            GradesPrototype.Data.DataSource.CreateData();
        }

        [TestMethod]
        public void TestValidGrade()
        {
            GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2012", "Math", "A-", "Very good");
            Assert.AreEqual(grade.AssessmentDate, "1/1/2012");
            Assert.AreEqual(grade.SubjectName, "Math");
            Assert.AreEqual(grade.Assessment, "A-");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBadDate()
        {
            GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2108", "Math", "A-", "Very good");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateNotRecognized()
        {
            GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "13/13/2017", "Math", "A-", "Very good");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBadAssessment()
        {
            GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2012", "Math", "F", "Very good");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBadSubject()
        {
            GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2012", "Astrology", "A-", "Very good");
        }
    }
}