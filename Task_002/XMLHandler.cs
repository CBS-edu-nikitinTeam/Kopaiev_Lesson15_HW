using System;

namespace Task_002
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Xml file  is opened");
        }

        public override void Create()
        {
            Console.WriteLine("Xml file  is created");
        }

        public override void Change()
        {
            Console.WriteLine("Xml file is changed");
        }

        public override void Save()
        {
            Console.WriteLine("Xml file is saved");
        }
    }
}