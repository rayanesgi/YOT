using System;
using NUnit.Framework;

namespace YOT.Test {
    [TestFixture]
    public class AssemblyTest {

        private AssemblyLoader assembly = new AssemblyLoader();

        [Test]
        public void Should_Load_Assembly() {
            Assert.IsTrue(assembly.loadAssembly("YOT.dll"));
            Assert.IsFalse(assembly.loadAssembly("YOTFAIL.dll"));
        }

        /*[Test]
        public void */
    }
}
