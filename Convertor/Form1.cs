using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace Convertor
{
    public partial class Form1 : Form
    {
        private readonly Thread _thread;
        private readonly Animation _animation;
        public Form1()
        {                           
            _animation = new Animation(); 
            _thread = new Thread(AnimationStart);
            InitializeComponent();  
            pictureBox.BackColor = Color.AliceBlue;          
        }

        private void AnimationStart()
        {
            timer.Start();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            pictureBox.Image = _animation.AddRectangles();
        }

        private void Convert_Click(object sender, EventArgs e)
        {    

            // Паралельне виконання анімації і конвертації 
            _thread.Start();
 
            // Виконання анімації і конвертація в одному потоці
            //timer.Start();


            if (radioButton_Xml_In.Checked && radioButton_Json_Out.Checked)
            {
                richTextBox_Out.Text = Convertxmlintojson(richTextBox_In.Text);
            }

            if (radioButton_Json_in.Checked && radioButton_Xml_Out.Checked)
            {
                richTextBox_Out.Text = Convertjsonintoxml(richTextBox_In.Text);
            }          
        }      

        static string Convertxmlintojson(string xml)
        {                      
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string json = JsonConvert.SerializeXmlNode(doc);
            return json;
        }

        static string Convertjsonintoxml(string json)
        {
            var doc = JsonConvert.DeserializeXmlNode(json);
            return doc.InnerXml;
        }
    }
}
