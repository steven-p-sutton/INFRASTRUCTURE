using System;
    public class Example : IExample
    {
        private string _name;
        private DateTime _dateOfJoining;
        public Example()
        {
        }

        public Example(string name, DateTime dateOfJoining)
        {
            _name = name;
            _dateOfJoining = dateOfJoining;
        }
        public string Name() { return _name; }
        public virtual DateTime GetDateOfJoining(int id) { return _dateOfJoining; }
    }