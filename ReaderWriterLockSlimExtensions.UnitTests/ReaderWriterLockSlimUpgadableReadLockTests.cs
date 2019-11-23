using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class ReaderWriterLockSlimUpgadableReadLockTests {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void ExampleUpgadableReadLockTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExercisUpgadableReadLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExercisUpgadableReadLock() {
            using (var upgadableReadLock = ReaderWriterLockSlim.UpgadableReadLock()) {

                using (var writeLock = upgadableReadLock.WriteLock()) {

                }
            }
        }
    }
}
