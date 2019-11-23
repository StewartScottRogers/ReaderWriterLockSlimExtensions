using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class ReaderWriterLockSlimReadLockTests {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void ExampleReadLockTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExercisReadLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExercisReadLock() {
            using (var readLock = ReaderWriterLockSlim.ReadLock()) {

            }
        }
    }
}
