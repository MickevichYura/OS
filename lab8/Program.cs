using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace lab8
{
    internal class Program
    {
        private sealed class WinApi
        {

            [Flags]
            private enum SnapshotFlags : uint
            {
                Process = 0x00000002,
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]

            private struct Processentry32
            {
                const int MaxPath = 260;
                internal UInt32 dwSize;
                private readonly UInt32 cntUsage;
                internal readonly UInt32 th32ProcessID;
                private readonly IntPtr th32DefaultHeapID;
                private readonly UInt32 th32ModuleID;
                private readonly UInt32 cntThreads;
                private readonly UInt32 th32ParentProcessID;
                private readonly int pcPriClassBase;
                private readonly UInt32 dwFlags;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxPath)]
                private readonly string szExeFile;
            }

            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
            static extern IntPtr CreateToolhelp32Snapshot([In]UInt32 dwFlags, [In]UInt32 th32ProcessId);

            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
            static extern bool Process32First([In]IntPtr hSnapshot, ref Processentry32 lppe);

            [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Auto)]
            static extern bool Process32Next([In]IntPtr hSnapshot, ref Processentry32 lppe);

            [DllImport("kernel32", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool CloseHandle([In] IntPtr hObject);


            private static void GetParentProcess()
            {
                var handleToSnapshot = IntPtr.Zero;
                try
                {
                    Processentry32 procEntry = new Processentry32
                    {
                        dwSize = (uint)Marshal.SizeOf(typeof(Processentry32))
                    };
                    handleToSnapshot = CreateToolhelp32Snapshot((uint)SnapshotFlags.Process, 0);
                    if (Process32First(handleToSnapshot, ref procEntry))
                    {
                        do
                        {
                            var parentProc = Process.GetProcessById((int)procEntry.th32ProcessID);

                            Console.WriteLine("Name= {0}, processId= {1}, priority= {2}, threadsCount= {3}, WorkingSet64= {4}",
                                parentProc.ProcessName, parentProc.Id, parentProc.BasePriority, parentProc.Threads.Count, parentProc.WorkingSet64);
                           
                        } while (Process32Next(handleToSnapshot, ref procEntry));
                    }
                    else
                    {
                        throw new ApplicationException(string.Format("Failed with win32 error code {0}", Marshal.GetLastWin32Error()));
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Can't get the process.", ex);
                }
                finally
                {
                    CloseHandle(handleToSnapshot);
                }
            }

            public static void Main()
            {
                GetParentProcess();
                Console.ReadKey();
            }
        }
    }
}
