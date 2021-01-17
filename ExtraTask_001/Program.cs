using System;
using System.Text;

namespace ExtraTask_001
{
    class Program
    {
        static void Main(string[] args)
        {

            Title title = new Title("Contract Example");
            Body body = new Body("Contract Text");
            Footer footer = new Footer("Contract footer");

            Document document = new Document(body, footer, title);

            document.ShowDocument();
            
            //Delay
            Console.ReadKey();
        }
    }
}
