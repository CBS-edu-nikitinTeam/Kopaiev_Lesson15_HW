using System;

namespace ExtraTask_001
{
    class Footer : Content
    {
        private readonly string _content;
        public Footer(string content)
        {
            this._content = content;
        }
        public override void Show()
        {
            Console.WriteLine(_content);
        }

    }
}