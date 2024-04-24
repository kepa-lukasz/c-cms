using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominik_CMS
{
    public class Article
    {

        public String ID { get; set; }
        public String Title { get; set; }
        public String Subtitle { get; set; }
        public String Date { get; set; }
        public String Author { get; set; }
        public String MainImg { get; set; }
        public List<ArticleElement> articleElements { get; set; }
         
    }
}
