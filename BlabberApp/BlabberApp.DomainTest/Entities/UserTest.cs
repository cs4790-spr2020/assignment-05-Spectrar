using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DomainTest.Entities {
    [TestClass]
    public class UserTest {
        [TestMethod]
        public void TestSetGetEmail_Success() {
            // Arrange
            User harness = new User();
            string expected = "test@example.com";
            harness.ChangeEmail("test@example.com");
            // Act
            string actual = harness.Email; // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_Fail0Test0() {
            // Arrange
            User harness = new User();

            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail("test"));
            // Assert
            Assert.AreEqual("test is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_FailTest1() {
            // Arrange
            User harness = new User();
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail("example.com"));
            // Assert
            Assert.AreEqual("example.com is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestSetGetEmail_FailTest2() {
            // Arrange
            User harness = new User();
            // Act
            var ex = Assert.ThrowsException<FormatException>(() => harness.ChangeEmail("test.example"));
            // Assert
            Assert.AreEqual("test.example is invalid", ex.Message.ToString());
        }
        [TestMethod]
        public void TestId() {
            // Arrange
            User harness = new User();
            Guid expected = harness.Id;
            // Act
            Guid actual = harness.Id;
            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
