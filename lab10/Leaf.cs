using System;

namespace lab10
{
    [Serializable]
    public class Leaf
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }

        public Leaf(string name, string type, string key)
        {
            Name = name;
            Type = type;
            Key = key;
        }
    }
}