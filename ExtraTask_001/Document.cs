namespace ExtraTask_001
{
    class Document
    {
        private readonly Body _body;
        private readonly Footer _footer;
        private readonly Title _title;
        public Document(Body body, Footer footer, Title title)
        {
            this._body = body;
            this._footer = footer;
            this._title = title;
        }
        public void ShowDocument()
        {
            _title.Show();
            _body.Show();
            _footer.Show();
        }
    }
}