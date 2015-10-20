using System;

namespace lab9
{
    class Data
    {
        public int Number { get; set; }
        public string[] StringArray { get; set; }
        public byte[] ByteArray { get; set; }
        public string StringValue { get; set; }

        public Data(int number, string[] stringArray, byte[] byteArray, string stringValue)
        {
            Number = number;
            StringArray = stringArray;
            ByteArray = byteArray;
            StringValue = stringValue;
        }

    }
}