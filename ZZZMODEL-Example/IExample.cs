using System;
using System.Collections.Generic;

namespace Conductus.EXAMPLE.Model
{
    public interface  IExample
    {
        public string Str { get; set; }
        public int Int { get; set; }
        public List<string> Repository { get; set; }
        public int Add(string item);
        public string Remove(int idx);
        public int Find(string item);
    }
}
