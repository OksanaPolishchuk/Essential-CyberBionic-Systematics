namespace BookApp
{
    public class Document
    {
        Title _title;
        Body _body;
        Author _author;

        private void InitializeDocument()
        {
            this._title = new Title();
            this._body = new Body();
            this._author = new Author();
        }

        public Document(string title)
        {
            InitializeDocument();
            this._title.Content = title;
        }

        public Document(string title, string author, string body)
        {
            InitializeDocument();
            this._title.Content = title;
            this._author.Content = author;
            this._body.Content = body;
        }

        public void Show()
        { 
            _title.Show();
            _body.Show();
            _author.Show();
        }

        public string Concatenate()
        {
            return _title.Content + "\n" + _author.Content
                   + "\n" + _body.Content;
        }

        public string Body
        {
            set
            {
                _body.Content = value;
            }
        }

        public string Author
        {
            set
            {
                _author.Content = value;
            }
        }

    }
}
