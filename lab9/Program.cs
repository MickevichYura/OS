using System;
using Microsoft.Win32;

namespace lab9
{
    internal static class Program
    {
        private static void Main()
        {
            RegistryKey[] registryKeys = { Registry.CurrentUser };

            Data data = new Data(666, new[] {"One", "Two", "Three"}, new byte[] {4, 8, 15, 16, 23, 42},
                "The java_home is %JAVA_HOME%");
            string subKey = "TestKey";

            foreach (var key in registryKeys)
            {
                RegistryKey rk = WorkWithRegistry(key, subKey, data);
                //RegistryKey rk = key.CreateSubKey(subKey);
                DisplayRegistryKeys(key, subKey);
            }

            Registry.SetValue(@"HKEY_CURRENT_USER\TestKey", "DWordValue", 6666);
            Console.WriteLine(Registry.GetValue(@"HKEY_CURRENT_USER\TestKey", "DWordValue", null));


            //Console.WriteLine();
            ////Registry.PerformanceData.CreateSubKey("Test");
            //foreach (var values in Registry.PerformanceData.GetValueNames())
            //{
            //    Console.WriteLine(values);
            //}

            //DeleteSubKey(registryKeys[0], "TestKey");

            Console.Read();
        }

        public static void DeleteSubKey(RegistryKey registryKey, String subKey)
        {
            registryKey.DeleteSubKey(subKey, false);
        }

        private static RegistryKey WorkWithRegistry(RegistryKey registryKey, String subKey, Data data)
        {

            registryKey = registryKey.CreateSubKey(subKey);

            //registryKey.DeleteSubKey(subKey, false);
            //registryKey = registryKey.CreateSubKey(subKey);

            // This overload supports QWord (long) values. 
            registryKey.SetValue("QuadWordValue", data.Number, RegistryValueKind.QWord);

            // The following SetValue calls have the same effect as using the
            // SetValue overload that does not specify RegistryValueKind.
            //
            registryKey.SetValue("DWordValue", data.Number, RegistryValueKind.DWord);
            registryKey.SetValue("MultipleStringValue", data.StringArray, RegistryValueKind.MultiString);
            registryKey.SetValue("BinaryValue", data.ByteArray, RegistryValueKind.Binary);
            registryKey.SetValue("StringValue", data.StringValue, RegistryValueKind.String);
            // This overload supports setting expandable string values.
            registryKey.SetValue("ExpandedStringValue", data.StringValue, RegistryValueKind.ExpandString);

            return registryKey;
        }

        private static void DisplayRegistryKeys(RegistryKey registryKey, String subKey)
        {
            registryKey = registryKey.CreateSubKey(subKey);

            Console.WriteLine("=========");
            Console.WriteLine(registryKey.Name);
            Console.WriteLine("=========");

            // Display all name/value pairs stored in the test key, with each
            // registry data type in parentheses.
            //
            string[] valueNames = registryKey.GetValueNames();
            foreach (string s in valueNames)
            {
                RegistryValueKind rvk = registryKey.GetValueKind(s);
                switch (rvk)
                {
                    case RegistryValueKind.MultiString:
                        string[] values = (string[]) registryKey.GetValue(s);
                        Console.Write("\r\n {0} ({1}) =", s, rvk);
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (i != 0) Console.Write(",");
                            Console.Write(" \"{0}\"", values[i]);
                        }
                        Console.WriteLine();
                        break;

                    case RegistryValueKind.Binary:
                        byte[] bytes = (byte[]) registryKey.GetValue(s);
                        Console.Write("\r\n {0} ({1}) =", s, rvk);
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            // Display each byte as two hexadecimal digits.
                            Console.Write(" {0:X2}({0:})", bytes[i]);
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("\r\n {0} ({1}) = {2}", s, rvk, registryKey.GetValue(s));
                        break;
                }
            }
        }
    }
}
