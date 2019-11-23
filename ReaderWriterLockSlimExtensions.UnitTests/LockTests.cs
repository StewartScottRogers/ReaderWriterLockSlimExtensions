using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class LockTests {

        private static readonly object SyncLock = new object();

        [TestMethod]
        public void ExampleReadLockTest() {
            lock (SyncLock) {

            }
        }
    }
}
