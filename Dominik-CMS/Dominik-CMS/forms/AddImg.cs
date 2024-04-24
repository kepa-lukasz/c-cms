using Newtonsoft.Json;
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

namespace Dominik_CMS
{
    public partial class AddImg : Form
    {
        public class ImageDataClass
        {
            public string underline { get; set; }
            public string alt { get; set; }
        }
        public static String ImageName { get; set; }
        public static String ImageData { get; set; }
        public AddImg(string editedIndex)
        {


            InitializeComponent();
            if (!String.IsNullOrEmpty(editedIndex))
            {
                foreach (var line in AddArticle.article.articleElements)
                {
                    if (editedIndex == Convert.ToString(line.ID))
                    {
                        textBox4.Text = line.Title;
                        var newData = JsonConvert.DeserializeObject<ImageDataClass>(line.Data);
                        textBox2.Text = newData.underline;
                        textBox3.Text = newData.alt;
                        break;
                    }
                }
            }
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            ImageName = textBox4.Text;
            ImageData = "{ 'underline' : '" + textBox2.Text + "', alt: '" + textBox3.Text + "'}";

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
