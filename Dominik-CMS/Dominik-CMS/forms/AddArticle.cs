using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dominik_CMS
{


    public partial class AddArticle : Form
    {
        private void deleteelement(String deletedIndex)
        {
            try
            {
                foreach (var line in article.articleElements)
                {
                    if (Convert.ToString(line.ID) == deletedIndex)
                    {
                        article.articleElements.Remove(line);
                        MessageBox.Show("Usunięto fragment artykułu");
                        break;
                    }
                }
                listView1.Items.Clear();
                foreach (var line in article.articleElements)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(line.ID));
                    item.SubItems.Add((line.Selector == "p") ? "akapit" : "obraz");
                    item.SubItems.Add(line.Title);
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void addimage(String data)
        {
            using (AddImg addimg = new AddImg(data))
            {
                if (addimg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var newImg = new ArticleElement();
                    newImg.ID = counter;
                    newImg.Selector = "img";
                    newImg.Title = AddImg.ImageName;
                    newImg.Data = AddImg.ImageData;
                    if (article.articleElements is null)
                    {
                        article.articleElements = new List<ArticleElement>() { newImg };
                    }
                    else
                    {
                        article.articleElements.Add(newImg);
                    }

                    ListViewItem item = new ListViewItem(Convert.ToString(newImg.ID));
                    item.SubItems.Add("obraz");
                    item.SubItems.Add(newImg.Title);
                    listView1.Items.Add(item);
                    counter++;
                    if (!String.IsNullOrEmpty(data))
                    {
                        deleteelement(textBox3.Text);
                    }
                }
            }
        }

        private void addparagraph(String data)
        {
            using (AddP addp = new AddP(data))
            {
                if (addp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var newP = new ArticleElement();
                    newP.ID = counter;
                    newP.Selector = "p";
                    newP.Title = AddP.Title;
                    newP.Data = AddP.Data;
                    if (article.articleElements is null)
                    {
                        article.articleElements = new List<ArticleElement>() { newP };
                    }
                    else
                    {
                        article.articleElements.Add(newP);
                    }

                    ListViewItem item = new ListViewItem(Convert.ToString(newP.ID));
                    item.SubItems.Add("akapit");
                    item.SubItems.Add(newP.Title);
                    listView1.Items.Add(item);
                    counter++;
                    if (!String.IsNullOrEmpty(data))
                    {
                        deleteelement(textBox3.Text);
                    }
                }

            }
        }

        private void addItemToList(ArticleElement line)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(line.ID));
            item.SubItems.Add((line.Selector == "p")? "akapit" : "obraz");
            item.SubItems.Add(line.Title);
            listView1.Items.Add(item);
            item.Remove();
        }

        public int counter = 0;

        SaveArticle savearticle = new SaveArticle();
        public static Article article = new Article();




        public AddArticle()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addparagraph("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addimage("");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            article.ID = "0";
            article.Title = articleTitle.Text;
            article.Subtitle = articleSubtitle.Text;
            article.Author = articleAuthor.Text;
            article.MainImg = articleMainImage.Text;
            article.Date = articleDate.Text;

            if (savearticle.savepost(article))
            {
            this.Close();
                MessageBox.Show("post został dodany!");
            }
        }





        private void button6_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Czy chcesz usunąć fragment artykułu?", "Potwierdź usunięcie", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                deleteelement(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //sprawdź, czy dobra ilość indexów podana
            var newOrder = textBox2.Text.Split(',');
            if (article.articleElements.Count() == newOrder.Count())
            {

                var newOrderedElements = new List<ArticleElement>();
                //tworzenie kolejności
                foreach (var index in newOrder)
                {
                    var trimindex = index.Trim();
                    foreach (var item in article.articleElements)
                    {
                        if (trimindex == Convert.ToString(item.ID))
                        {
                            newOrderedElements.Add(item);
                        }
                    }
                }
                // user określa, czy o to mu chodziło
                var controlString = "";
                foreach (var line in newOrderedElements)
                {
                    controlString += "\n " + line.Title;
                }
                var confrmation = MessageBox.Show(controlString, "Sprawdź, czy kolejność jest odpowiadająca", MessageBoxButtons.YesNo);
                //jeśli dobra kolejność zapisz
                if (confrmation == DialogResult.Yes)
                {
                    Debug.WriteLine("śmiga");
                    article.articleElements = newOrderedElements;

                    var counter = 0;
                    foreach (var line in article.articleElements)
                    {
                        ListViewItem item = listView1.Items[counter];
                        item.SubItems[0].Text = Convert.ToString(line.ID);
                        item.SubItems[2].Text = line.Title;
                        item.SubItems[1].Text = line.Selector;
                        counter++;
                    }
                };
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {



            foreach (var line in article.articleElements)
            {
                if (Convert.ToString(line.ID) == textBox3.Text)
                {
                    if (line.Selector == "p")
                    {
                        addparagraph(textBox3.Text);
                    }
                    else
                    {
                        addimage(textBox3.Text);
                        
                    }
                    break;
                }
            }
        }
    }
}
