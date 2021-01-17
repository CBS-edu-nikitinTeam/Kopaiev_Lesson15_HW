using System;

namespace Task_002
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT file is opened");
        }

        public override void Create()
        {
            Console.WriteLine("TXT file is created");
        }

        public override void Change()
        {
            Console.WriteLine("TXT file is changed");
        }

        public override void Save()
        {
            Console.WriteLine("TXT file is saved");
        }
    }
}