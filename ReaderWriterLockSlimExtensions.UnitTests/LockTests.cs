using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class LockTests {

        private static readonly object SyncLock = new object();

        [TestMethod]
        public void Exercise_Lock_0000000001_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0000000001_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0000000010_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0000000100_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0000001000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0000010000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0000100000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0001000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0010000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000000))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_0100000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000000))
                ExerciseLock();
        }

        [TestMethod]
        public void Exercise_Lock_1000000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000000))
                ExerciseLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExerciseLock() {
            lock (SyncLock) {

            }
        }
    }
}
