﻿namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string GetMessage(string Name)
        {
            return $"Hello {Name}";
        }
    }
}