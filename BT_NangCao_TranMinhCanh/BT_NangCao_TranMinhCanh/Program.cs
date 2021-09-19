using BT_NangCao_TranMinhCanh.ID;
using BT_NangCao_TranMinhCanh.Rssfeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BT_NangCao_TranMinhCanh
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            INewRepository repository = new NewsRepository();
            NewsParser parser = new NewsParser();
            RssReader reader = new RssReader(parser);
            var manager = new NewsFeedManager(repository, reader);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(manager));
        }
    }
}
