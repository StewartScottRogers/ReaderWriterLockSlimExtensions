using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class ReaderWriterLockSlimWriteLockTests {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void Exercise_WriteLock_0000000001_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0000000001_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0000000010_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0000000100_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0000001000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0000010000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0000100000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0001000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0010000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000000))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_0100000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000000))
                ExerciseWriteLock();
        }

        [TestMethod]
        public void Exercise_WriteLock_1000000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000000))
                ExerciseWriteLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExerciseWriteLock() {
            using (var writeLock = ReaderWriterLockSlim.WriteLock()) {

            }
        }
    }
}
