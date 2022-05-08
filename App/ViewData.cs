using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace App
{
    public partial class ViewData : Form
    {
        SQLiteConnection con;
        public ViewData()
        {
            InitializeComponent();
            con = new SQLiteConnection("Data Source=Web.sqlite;Version=3;");
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From News", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
            read.GetValue(0),  // U can use column index
            read.GetValue(read.GetOrdinal("Name")),  // Or column name like this
            read.GetValue(read.GetOrdinal("Summary")),
            read.GetValue(read.GetOrdinal("Date"))
            });
                }
            }
        }
    }
}
