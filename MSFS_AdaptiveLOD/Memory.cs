using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MSFS_AdaptiveLOD
{
    public class Memory
    {

        private static Process m_iProcess;
        private static IntPtr m_iProcessHandle;

        private static int m_iBytesWritten;
        private static int m_iBytesRead;

        public static bool Attach(string ProcName)
        {
            if (Process.GetProcessesByName(ProcName).Length > 0)
            {
                m_iProcess = Process.GetProcessesByName(ProcName)[0];
                m_iProcessHandle =
                    NativeMethods.OpenProcess(Flags.PROCESS_VM_OPERATION | Flags.PROCESS_VM_READ | Flags.PROCESS_VM_WRITE,
                        false, m_iProcess.Id);
                return true;
            }

            return false;
        }

        public static string GetMainWindowTitle()
        {
            return m_iProcess.MainWindowTitle;
        }
        public static void WriteMemory<T>(long Address, object Value)
        {
            var buffer = StructureToByteArray(Value);

            NativeMethods.NtWriteVirtualMemory((int)m_iProcessHandle, Address, buffer, buffer.Length, out m_iBytesWritten);
        }

        public static void WriteMemory<T>(long Adress, char[] Value)
        {
            var buffer = Encoding.UTF8.GetBytes(Value);

            NativeMethods.NtWriteVirtualMemory((int)m_iProcessHandle, Adress, buffer, buffer.Length, out m_iBytesWritten);
        }

        public static T ReadMemory<T>(long address) where T : struct
        {
            var ByteSize = Marshal.SizeOf(typeof(T));

            var buffer = new byte[ByteSize];

            NativeMethods.NtReadVirtualMemory((int)m_iProcessHandle, address, buffer, buffer.Length, out m_iBytesRead);

            return ByteArrayToStructure<T>(buffer);
        }

        public static byte[] ReadMemory(long offset, int size)
        {
            var buffer = new byte[size];

            NativeMethods.NtReadVirtualMemory((int)m_iProcessHandle, offset, buffer, size, out m_iBytesRead);

            return buffer;
        }

        public static float[] ReadMatrix<T>(long Adress, int MatrixSize) where T : struct
        {
            var ByteSize = Marshal.SizeOf(typeof(T));
            var buffer = new byte[ByteSize * MatrixSize];
            NativeMethods.NtReadVirtualMemory((int)m_iProcessHandle, Adress, buffer, buffer.Length, out m_iBytesRead);

            return ConvertToFloatArray(buffer);
        }

        public static long GetModuleAddress(string Name)
        {
            try
            {
                foreach (ProcessModule ProcMod in m_iProcess.Modules)
                    if (Name == ProcMod.ModuleName)
                        return (long)ProcMod.BaseAddress;
            }
            catch
            {
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Cannot find - " + Name + " | Check file extension.");
            Console.ResetColor();

            return -1;
        }

        #region Other

        internal struct Flags
        {
            public const int PROCESS_VM_OPERATION = 0x0008;
            public const int PROCESS_VM_READ = 0x0010;
            public const int PROCESS_VM_WRITE = 0x0020;
        }

        #endregion

        #region Conversion

        public static float[] ConvertToFloatArray(byte[] bytes)
        {
            if (bytes.Length % 4 != 0)
                throw new ArgumentException("Array length doesn't align to 4 bytes!");

            var floats = new float[bytes.Length / 4];

            for (var i = 0; i < floats.Length; i++)
                floats[i] = BitConverter.ToSingle(bytes, i * 4);

            return floats;
        }

        private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                handle.Free();
            }
        }

        private static byte[] StructureToByteArray(object obj)
        {
            var length = Marshal.SizeOf(obj);

            var array = new byte[length];

            var pointer = Marshal.AllocHGlobal(length);

            Marshal.StructureToPtr(obj, pointer, true);
            Marshal.Copy(pointer, array, 0, length);
            Marshal.FreeHGlobal(pointer);

            return array;
        }

        #endregion
    }

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        internal static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("ntdll.dll")]
        internal static extern IntPtr NtWriteVirtualMemory(int ProcessHandle, long BaseAddress, byte[] Buffer, int NumberOfBytesToWrite, out int NumberOfBytesWritten);
        [DllImport("ntdll.dll")]
        internal static extern bool NtReadVirtualMemory(int ProcessHandle, long BaseAddress, byte[] Buffer, int NumberOfBytesToRead, out int NumberOfBytesRead);
    }
}