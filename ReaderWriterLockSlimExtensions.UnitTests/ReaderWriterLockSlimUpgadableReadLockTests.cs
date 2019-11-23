using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class ReaderWriterLockSlimUpgadableReadLockTests {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000000001_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000000001_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000000010_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000000100_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000001000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000010000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0000100000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0001000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0010000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000000))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_0100000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000000))
                ExerciseUpgadableReadLock();
        }

        [TestMethod]
        public void Exercise_UpgadableReadLock_1000000000_Cycles_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000000))
                ExerciseUpgadableReadLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExerciseUpgadableReadLock() {
            using (var upgadableReadLock = ReaderWriterLockSlim.UpgadableReadLock()) {

                using (var writeLock = upgadableReadLock.WriteLock()) {

                }
            }
        }
    }
}
