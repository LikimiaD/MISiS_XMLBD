using System.Xml;
using System.ServiceModel.Syndication;
using SQlite;

namespace App
{
    public partial class Web : Form
    {
        public List<string> name = new List<string>();
        public List<string> summary = new List<string>();
        public List<string> date = new List<string>();
        SQlite.DataBase db = new DataBase();
        public Web(string url)
        {
            InitializeComponent();
            Xml(news, url);
        }
        // https://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml
        void Xml(RichTextBox news, string url)
        {
            SyndicationFeed feed = null;

            try
            {
                using (var reader = XmlReader.Create(url))
                {
                    feed = SyndicationFeed.Load(reader);
                }
            }
            catch { }

            if (feed != null)
            {
                foreach (var element in feed.Items)
                {
                    name.Add(element.Title.Text);
                    summary.Add(element.Summary.Text);
                    date.Add(element.PublishDate.ToString());
                    news.Text += $"Title: {element.Title.Text}.\n";
                    news.Text += $"Summary: {element.Summary.Text}\n";
                    news.Text += $"Time: {element.PublishDate}\n\n";
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            news.Text = "";
        }

        private void write_db_Click(object sender, EventArgs e)
        {
            db.CreateDB();
            db.AddData(name,summary,date);
        }

        private void view_db_Click(object sender, EventArgs e)
        {
            ViewData vd = new ViewData();
            vd.Show();
        }
    }
}
