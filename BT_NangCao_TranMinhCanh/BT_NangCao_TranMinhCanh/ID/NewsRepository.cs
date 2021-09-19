using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BT_NangCao_TranMinhCanh.model;

namespace BT_NangCao_TranMinhCanh.ID
{
    public class NewsRepository : INewRepository
    {
        private const string FilePath = "Data\\data.txt";
        public List<publisher> GetNews()
        {
            var publisher = new List<publisher>();
            publisher office = null;
            string line;

            try
            {
                using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            if (line.StartsWith("@"))
                            {
                                office = ParsePublishh(line);
                                publisher.Add(office);
                            }
                            else if (line.StartsWith("#") && office != null)
                            {
                                var category = ParseCate(line);
                                office.Categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return publisher;
        }

        public void Save(List<publisher> publishers)
        {
            using (var stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            {
                using (var w = new StreamWriter(stream))
                {
                    foreach (var item in publishers)
                    {
                        w.WriteLine("@{0}", item.Name);
                        foreach (var cate in item.Categories)
                        {
                            w.WriteLine("#{0}^{1}", cate.Name, cate.RssLink);
                        }
                    }
                }
            }
        }
        private publisher ParsePublishh(string info)
        {
            return new publisher()
            {
                Name = info.Substring(1).Trim()
            };
        }

        private Category ParseCate(string line)
        {
            var lines = line.Substring(1).Split('^');
            return new Category()
            {
                Name = lines[0].Trim(),
                RssLink = lines[1].Trim()
            };
        }
    }
}
