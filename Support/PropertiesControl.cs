using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static Rulate_Notifier_v4.BookClasses;

namespace Rulate_Notifier_v4.Support
{
    class PropertiesControl
    {
        #region var
        public static Dictionary<string, Book> BookDictionary = new Dictionary<string, Book>();
        private static BookCollection coll = new BookCollection();
        #endregion
        public static Book[] Load(string data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(BookCollection));
            StringReader stringReader = new StringReader(data);
            BookCollection collection = (BookCollection)xmlSerializer.Deserialize(stringReader);
            stringReader.Close();
            return collection.Array.ToArray();
        }
        private static string GetHtml(string indexBook)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://tl.rulate.ru/book/" + indexBook + "/");
            httpWebRequest.Method = "GET";
            //httpWebRequest.Host = "counter.yadro.ru";
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:55.0) Gecko/20100101 Firefox/55.0";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Headers.Add("Accept-Language", "ru - RU, ru; q = 0.8,en - US; q = 0.5,en; q = 0.3");
            httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            httpWebRequest.Referer = @"http://tl.rulate.ru/book/" + indexBook + "/";
            httpWebRequest.KeepAlive = true;
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var response = (HttpWebResponse)httpWebRequest.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            return responseString;
        }
        ////
        public static Book[] Load()
        {
            return Load(Properties.Settings.Default.Books);
        }
        public static void Save()
        {
            Clear();
            foreach (KeyValuePair<string, Book> a in BookDictionary)
                AddNew(a.Key, a.Value.Index, a.Value.Start);
        }
        public static void Clear()
        {
            coll.Array.Clear();
            ////
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(BookCollection));
            StringWriter stringWriter = new StringWriter();

            xmlSerializer.Serialize(stringWriter, coll);

            Properties.Settings.Default.Books = stringWriter.ToString();
            Properties.Settings.Default.Save();
        }
        public static void AddNew(string Name, string Index, string Start)
        {
            Book a = new Book() { Name = Name, Index = Index, Start = Start };
            coll.Array.Add(a);
            ////
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(BookCollection));
            StringWriter stringWriter = new StringWriter();

            xmlSerializer.Serialize(stringWriter, coll);

            Properties.Settings.Default.Books = stringWriter.ToString();
            Properties.Settings.Default.Save();
        }
        ////
        public static List<BookContainer> GetContainersByHtml(string html)
        {
            List<BookContainer> ListBookContainer = new List<BookContainer>();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//tr[@class='chapter_row  ']");

            foreach (HtmlNode n in nodes)
            {
                List<string> MassDat = new List<string>();
                foreach (HtmlNode childNode in n.ChildNodes)
                {
                    MassDat.Add(childNode.InnerText);
                    //1 - пустой; 2 - глава; 3 - состояние; 4 - дата; 5 - %; 6 - кнопка
                }
                ListBookContainer.Add(new BookContainer(MassDat[1], MassDat[2], MassDat[4], n.Attributes[1].Value));
            }
            return ListBookContainer;
        }
        public static List<BookContainer> GetContainersByIndex(string indexBook)
        {
            string temp = GetHtml(indexBook);
            return GetContainersByHtml(temp);
        }
    }
}
