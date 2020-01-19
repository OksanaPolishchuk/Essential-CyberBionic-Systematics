using System;

namespace BookApp
{
    class Title
    {
        private string _content;

        public string Content
        {
            get
            {
                if (_content != null)
                {

                    return _content;
                }
                else
                {
                    return "Empty";
                }
            }
            set
            {
                _content = value;

            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
