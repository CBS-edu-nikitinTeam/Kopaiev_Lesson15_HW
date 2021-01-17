using System;

namespace ExtraTask_001
{
    class Body : Content
    {
        private readonly string _content;
        public Body(string content)
        {
            this._content = content;
        }
        public override void Show()
        {
            Console.WriteLine(_content);
        }
    }
}