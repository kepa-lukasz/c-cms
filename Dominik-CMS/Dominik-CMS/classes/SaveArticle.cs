using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominik_CMS
{
    internal class SaveArticle
    {
        public bool savepost(Article article)
        {
            string relativepath = "..\\..\\application\\backend\\";
            string exactpath = Path.Combine(Environment.CurrentDirectory, relativepath);
            var confirmation = MessageBox.Show("Czy na pewno chcesz dodać ten post?", "Potwierdź dodanie artykułu", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var indexPath = exactpath + "index.html";
                    string text = File.ReadAllText(indexPath);

                    article.ID = text;
                    var newIndex = Convert.ToInt32(text);
                    newIndex++;
                    string json = JsonConvert.SerializeObject(article);

                    var newPostPath = exactpath + "jsons\\" + Convert.ToString(newIndex) + ".json";

                    File.Create(newPostPath).Close();
                    File.WriteAllText(newPostPath, json);

                    File.WriteAllText(indexPath, Convert.ToString(newIndex));



                    return (true);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Najlepiej skontaktuj się ze mną \\n" + Convert.ToString(e));
                    return (false);
                }


            }
            else
            {
                return (false);
            }

        }
    }
}
