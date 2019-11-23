using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class ReaderWriterLockSlimWriteLockTests {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void ExampleWriteLockTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseWriteLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExerciseWriteLock() {
            using (var writeLock = ReaderWriterLockSlim.WriteLock()) {

            }
        }
    }
}
