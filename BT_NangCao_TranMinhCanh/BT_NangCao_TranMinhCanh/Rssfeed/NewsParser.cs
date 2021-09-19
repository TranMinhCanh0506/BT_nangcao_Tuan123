using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using BT_NangCao_TranMinhCanh.model;

namespace BT_NangCao_TranMinhCanh.Rssfeed
{
    public class NewsParser
    {
        public List<article> ParseXml(string xmlContent)
        {
            var document = new XmlDocument();
            document.LoadXml(xmlContent);

            var acticles = new List<article>();
            var itemNodes = document.SelectNodes("//item");

            foreach (XmlNode node in itemNodes)
            {
                var news = new article()
                {
                    Title = node.SelectSingleNode("title").InnerText,
                    Description = node.SelectSingleNode("description").InnerText    ,
                    Link =node.SelectSingleNode("link").InnerText,
                    PublishedDate = ParseDate(node.SelectSingleNode("pubDate").InnerText)
                };
                acticles.Add(news);
            }
            return acticles;
        }
      
        private DateTime ParseDate(string dateStr)
        {
            try
            {
                return DateTime.Parse(dateStr);
            }
            catch (Exception)
            {

                return DateTime.Now;
            }
        }
    }
}
