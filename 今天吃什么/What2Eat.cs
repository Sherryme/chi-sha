﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace 今天吃什么
{
    public partial class What2Eat : CCSkinMain
    {
        public What2Eat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] food = { "番茄酸菜鱼", "番茄牛腩", "花甲粉丝汤" , "麻辣烫", "肉夹馍", "重庆小面", "肉酱刀削面", "锅盖面", "黄焖鸡米饭", "热干面", "蛋炒饭", "卤肉饭", "砂锅面", "鱼香肉丝", "宫保鸡丁", "糖醋里脊", "香菇青菜" };
            int random = new Random().Next(food.Length);
            MessageBox.Show("不如去吃"+food[random]+"吧","提示");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
