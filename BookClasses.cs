using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rulate_Notifier_v4
{
    public class BookClasses
    {

        public class Book
        {
            public override string ToString() { return Name; }
            [XmlElement("Name")]
            public string Name { get; set; } // Это будет элементом

            [XmlAttribute("Index")]
            public string Index { get; set; } // Это будет атрибутом

            [XmlAttribute("Start")]
            public string Start { get; set; } // Это будет атрибутом
        }
        public class BookCollection
        {
            [XmlArray("bookshelf"), XmlArrayItem("Book")]
            public List<Book> Array = new List<Book>();
        }
        public class BookContainer
        {
            public string name;
            public string status;
            public string percent;
            public string url;
            public BookContainer(string name, string status, string percent, string url)
            {
                this.name = name;
                this.status = status;
                this.percent = percent;
                this.url = url;
            }
        }

    }
}
