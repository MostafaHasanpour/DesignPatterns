using System;
using System.Linq;

namespace DesignPatterns.Structural.ProxyPattern
{
    public class Proxy : Subject
    {
        Subject cs;

        string[] _registeredUsers = new string[] { "Admin", "Rohit", "Sam" };

        string _currentUser;

        public Proxy(string currentUser)
        {
            _currentUser = currentUser;
        }

        public override void DoSomework()
        {
            Console.WriteLine("Proxy call happening now...");
            Console.WriteLine($"{_currentUser} want to invoke a proxy method.");

            if (_registeredUsers.Contains(_currentUser))
            {
                if (cs == null)
                {
                    cs = new ConcreteSubject1();
                }
                cs.DoSomework();
            }
            else
            {
                if (cs == null)
                {
                    cs = new ConcreteSubject2();
                }
                cs.DoSomework();
            }
        }
    }
}
