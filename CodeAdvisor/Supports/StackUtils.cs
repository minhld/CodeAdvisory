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
            parent.Items.Clear();
            ListViewItem listItem = null;
            for (int i = 0; i < stackItems.Count(); i++)
            {
                listItem = new ListViewItem(new [] { stackItems[i].author,
                                                    stackItems[i].title,
                                                    !stackItems[i].answer.Equals(string.Empty) ? "1" : "0",
                                                    String.Format("{0:0.000}", double.Parse(stackItems[i].score)),
                                                    String.Format("{0:0.000}", double.Parse(stackItems[i].qscore)),
                                                    String.Format("{0:0.000}", double.Parse(stackItems[i].acscore)),
                                                    String.Format("{0:0.000}", double.Parse(stackItems[i].apiscore)),
                                                    String.Format("{0:0.000}", double.Parse(stackItems[i].urscore))});
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
                stackItem.answer = questions[i]["answer"].Count() > 0 ? questions[i]["answer"]["Body"].ToString().Trim() : "";
                stackItem.score = questions[i]["Scores"]["Total"].ToString();
                stackItem.qscore = questions[i]["Scores"]["Question"].ToString();
                stackItem.acscore = questions[i]["Scores"]["Accepted"].ToString();
                stackItem.apiscore = questions[i]["Scores"]["API"].ToString();
                stackItem.urscore = questions[i]["Scores"]["UserReputation"].ToString();

                stackItems.Add(stackItem);
            }
        }
    }
}
