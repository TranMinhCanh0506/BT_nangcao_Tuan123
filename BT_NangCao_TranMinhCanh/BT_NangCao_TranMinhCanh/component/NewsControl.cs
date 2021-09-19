using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT_NangCao_TranMinhCanh.model;

namespace BT_NangCao_TranMinhCanh.component
{
    public partial class NewsControl : UserControl
    {
        public NewsControl()
        {
            InitializeComponent();
        }

        public void SetArticle(article news)
        {
            lbTitle.Text = news.Title;
            lbDescription.Text = news.Description;
            lbPublisherDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
            lblDetail.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height - 2);
        }

       
    }
}
