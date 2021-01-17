using System;

namespace ExtraTask_001
{
    class Title : Content
    {
        private readonly string _content;
        public Title(string content)
        {
            this._content = content;
        }
        public override void Show()
        {
            Console.WriteLine(_content);
        }
    }
}