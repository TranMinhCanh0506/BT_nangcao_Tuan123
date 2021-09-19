using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using BT_NangCao_TranMinhCanh.model;

namespace BT_NangCao_TranMinhCanh.Rssfeed
{
    public class RssReader
    {
        private readonly NewsParser _parser;

        public RssReader(NewsParser parser)
        {
            _parser = parser;
        }

        public List<article> GetNews(string rssLink)
        {
            var feedData = DownloadFeed(rssLink);
            return _parser.ParseXml(feedData);
        }

        private string DownloadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            return client.DownloadString(rssLink);
        }
    }
}
