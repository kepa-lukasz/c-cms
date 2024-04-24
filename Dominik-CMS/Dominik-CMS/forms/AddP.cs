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
     
    public partial class AddP : Form

    {
        public static String Title { get; set; }   
        public static String Data { get; set; }


        public AddP(String editedIndex)
        {
            InitializeComponent();
            if (! String.IsNullOrEmpty(editedIndex))
            {
                foreach (var line in AddArticle.article.articleElements)
                {
                    if(editedIndex == Convert.ToString(line.ID))
                    {
                        PName.Text = line.Title;
                        p.Text = line.Data;
                        break;
                    }
                }
            }
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            Title = PName.Text;
            Data = p.Text;
        }

    }
}
