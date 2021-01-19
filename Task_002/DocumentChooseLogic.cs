using System;

namespace Task_002
{
    class DocumentChooseLogic // Для класса так себе название. Document к примеру. А в методах ты уже
                              // описываешь работу класса, его поведение.
    {
        public DocumentChooseLogic(string input)
        {
            FileTypeSelector(input);
        }

        private static void FileTypeSelector(string input)
        {
            AbstractHandler file;

            if (input == "xml")
            {
                Console.WriteLine("You choose xml\n");
                file = new XMLHandler();
            }
            else if (input == "txt")
            {
                Console.WriteLine("You choose txt\n");
                file = new TXTHandler();

            }
            else if (input == "doc")
            {
                Console.WriteLine("You choose doc\n");
                file = new DOCHandler();
            }
            else
            {
                Console.WriteLine("Wrong Input\n");
                return;
            }
            // Красота!!!
            file.Create();
            file.Open();
            file.Change();
            file.Save();
        }
    }
}