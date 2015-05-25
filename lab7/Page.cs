using System;

namespace lab7
{
    class Page
    {
        public string Name { get; private set; }
        public bool Reading { get; private set; }
        public bool Modifying { get; private set; }
        public int Time;
        public int ClassType
        {
            get { return 2 * Convert.ToInt32(Reading) + Convert.ToInt32(Modifying); }
        }


        public Page(string name, bool reading = true, bool modifying = true, int time = 0)
        {
            Name = name;
            Reading = reading;
            Modifying = modifying;
            Time = time;
        }
    }
}
