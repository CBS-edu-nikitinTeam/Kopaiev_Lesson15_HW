using System;

namespace Task_002
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC file is opened");
        }

        public override void Create()
        {
            Console.WriteLine("DOC file is created");
        }

        public override void Change()
        {
            Console.WriteLine("DOC file is changed");
        }

        public override void Save()
        {
            Console.WriteLine("DOC file is saved");
        }
    }
}