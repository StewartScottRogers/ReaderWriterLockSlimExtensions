using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class SmokeTest {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void ExampleReadLockTest() {
            using (var readLock = ReaderWriterLockSlim.ReadLock()) {

            }
        }

        [TestMethod]
        public void ExampleWriteLockTest() {
            using (var writeLock = ReaderWriterLockSlim.WriteLock()) {

            }
        }


        [TestMethod]
        public void ExampleUpgadableReadLockTest() {
            using (var upgadableReadLock = ReaderWriterLockSlim.UpgadableReadLock()) {

                using (var writeLock = upgadableReadLock.WriteLock()) {

                }
            }
        }
    }
}
