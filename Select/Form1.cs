using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable province = new Hashtable();
        Hashtable city = new Hashtable();
        private void Province()
        {
            province.Add("云南省",new string[] {"昆明市","玉溪市" });
            province.Add("四川省", new string[] { "成都市", "绵阳市" });
            city.Add("昆明市",new string[] {"盘龙区","五华区" });
            city.Add("玉溪市",new string[] {"红塔区","。。。区" });
            city.Add("成都市", new string[] { "。。。区", "。。。区" });
            city.Add("绵阳市", new string[] { "...区", "...区" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Province();
            foreach (string str in province.Keys)
            {
                comboBox1.Items.Add(str);
            }
            foreach (string str in city.Keys)
            {
                comboBox2.Items.Add(str);
            }
            comboBox1.SelectedIndex=0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] citys = province[comboBox1.Text] as string[];
            comboBox2.Items.Clear();
            foreach (string s in citys)
            {
                comboBox2.Items.Add(s);
            } 
            comboBox2.SelectedIndex = 0;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] citys = city[comboBox2.Text] as string[];
            comboBox3.Items.Clear();
            foreach (string str in citys)
            {
                comboBox3.Items.Add(str);
            }
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
