using System;

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
            this._title.Show();
            this._body.Show();
            this._author.Show();
        }

        public string Concatenate()
        {
            return this._title.Content + "\n" + this._author.Content
                   + "\n" + this._body.Content;
        }

        public string Body
        {
            set
            {
                this._body.Content = value;
            }
        }

        public string Author
        {
            set
            {
                this._author.Content = value;
            }
        }

    }
}
