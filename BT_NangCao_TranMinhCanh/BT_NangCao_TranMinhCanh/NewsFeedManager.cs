using System;
using System.Collections.Generic;
using System.Text;
using BT_NangCao_TranMinhCanh.ID;
using BT_NangCao_TranMinhCanh.model;
using BT_NangCao_TranMinhCanh.Rssfeed;

namespace BT_NangCao_TranMinhCanh
{
    public class NewsFeedManager
    {
        private readonly INewRepository _newRepository;
        private List<publisher> _publisher;
        private readonly RssReader _rssReader;
        public NewsFeedManager(INewRepository newRepository, RssReader rssReader)
        {
            _newRepository = newRepository;
            _rssReader = rssReader;
        }
        public List<publisher> GetNewFeed()
        {
            if (_publisher == null)
            {
                _publisher = _newRepository.GetNews();
            }
            return _publisher;
        }
        public void SaveChange()
        {
            _newRepository.Save(_publisher);
        }
        public void RemovePublish(string publisherName)
        {
            _publisher.RemoveAll(x => x.Name == publisherName);
            SaveChange();
        }
        public void RemoveCate(string publisherName, string categoryName)
        {
            var publisher = _publisher.Find(x => x.Name == publisherName);
            if (publisher == null)
                return;
            publisher.RemoveCate(categoryName);
            SaveChange();
        }
        public bool AddCategory(string publishName, string categoryName, string rsslink, bool UploadExists)
        {
            var pub = _publisher.Find(x => x.Name == publishName);
            if (pub == null)
            {
                pub = new publisher()
                {
                    Name = publishName
                };
                _publisher.Add(pub);
            }
            return pub.AddCategory(categoryName, rsslink, UploadExists);
        }
        public List<article> GetNews(string publisherName, string categoryName)
        {
            var publisher = _publisher.Find(x => x.Name == publisherName);
            if (publisher == null) return new List<article>();

            var category = publisher.Categories.Find(x => x.Name == categoryName);
            if (category == null) return new List<article>();

            if (category.Acticles.Count == 0)
            {
                category.Acticles = _rssReader.GetNews(category.RssLink);
            }
            return category.Acticles;
        }
    }
}
