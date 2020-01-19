using System;

namespace BookApp
{
    class Document
    {
        Title title = null;
        Body _body = null;
        Author author = null;

        private void InitializeDocument()
        {
            this.title = new Title();
            this._body = new Body();
            this.author = new Author();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public void Show()
        { 
            this.title.Show();
            this._body.Show();
            this.author.Show();
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
                this.author.Content = value;
            }
        }

    }
}
