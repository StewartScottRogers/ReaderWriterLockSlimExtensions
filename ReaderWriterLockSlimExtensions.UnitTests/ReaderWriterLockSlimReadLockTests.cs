using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ReaderWriterLockSlimExtensions.UnitTests {

    [TestClass]
    public class ReaderWriterLockSlimReadLockTests {

        private static readonly ReaderWriterLockSlim ReaderWriterLockSlim = new ReaderWriterLockSlim();

        [TestMethod]
        public void Exercise_ReadLock_0000000001_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0000000010_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0000000100_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0000001000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0000010000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0000100000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0001000000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0010000000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 10000000))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_0100000000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 100000000))
                ExerciseReadLock();
        }

        [TestMethod]
        public void Exercise_ReadLock_1000000000_Cycles_In_Order_To_Warmup_UnitTest() {
            foreach (var index in Enumerable.Range(1, 1000000000))
                ExerciseReadLock();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExerciseReadLock() {
            using (var readLock = ReaderWriterLockSlim.ReadLock()) {

            }
        }
    }
}
