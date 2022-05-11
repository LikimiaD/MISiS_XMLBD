
namespace App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            url_textbox.Text = "https://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Web web = new Web(url_textbox.Text);
            web.Show();
        }

        private void web_open_Click(object sender, EventArgs e)
        {
            Web web = new Web("");
            web.Show();
        }
    }
}