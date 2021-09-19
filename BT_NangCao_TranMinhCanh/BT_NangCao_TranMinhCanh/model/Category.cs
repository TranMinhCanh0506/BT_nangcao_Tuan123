using System;
using System.Collections.Generic;
using System.Text;

namespace BT_NangCao_TranMinhCanh.model
{
    public class Category
    {

        public string Name { get; set; }
        public string RssLink { get; set; }
        public List<article> Acticles { get; set; }
        public Category()
        {
            Acticles = new List<article>();
        }
    }
}
