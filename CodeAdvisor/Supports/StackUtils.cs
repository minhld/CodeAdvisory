using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace CodeAdvisor.Supports
{
    class StackUtils
    {
        private static List<StackItem> stackItems = null;

        public static List<StackItem> StackItem
        {
            set
            {
                stackItems = value;
            }
            get
            {
                return stackItems;
            }
        }

        public static void drawListItems(ListView parent)
        {
            ListViewItem listItem = null;
            for (int i = 0; i < stackItems.Count(); i++)
            {
                listItem = new ListViewItem(new [] { stackItems[i].author, stackItems[i].title, stackItems[i].score });
                listItem.Tag = stackItems[i];
                parent.Items.Add(listItem);
            }
        }

        public static void getStackItems(string jsonRes)
        {
            stackItems = new List<StackItem>();
            
            // no data parsed
            if (jsonRes.Equals(string.Empty)) return;

            JObject stackObjects = (JObject)JsonConvert.DeserializeObject(jsonRes);
            var dataObjects = stackObjects["data"];
            List<JToken> questions = dataObjects.Children().ToList();

            StackItem stackItem = null;
            for (int i = 0; i < questions.Count; i++)
            {
                stackItem = new StackItem();
                stackItem.title = questions[i]["question"]["Title"].ToString();
                stackItem.question = questions[i]["question"]["Body"].ToString();
                stackItem.author = questions[i]["question"]["Owner"]["Display_name"].ToString();
                stackItem.authorImageUrl = questions[i]["question"]["Owner"]["Profile_image"].ToString();
                stackItem.qlink = questions[i]["question"]["Link"].ToString();
                stackItem.answer = questions[i]["answer"].Count() > 0 ? questions[i]["answer"]["Body"].ToString() : "";
                stackItem.score = questions[i]["Scores"]["Total"].ToString();

                stackItems.Add(stackItem);
            }
        }
    }
}
