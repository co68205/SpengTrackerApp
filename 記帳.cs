using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        Money spend;
        int income;
        int[] categoryIndex = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0};
        int sum = 0;
        int remain = 0;
        int categorySpend = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void incomeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void spendInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void remainShow_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            income += int.Parse(incomeInput.Text);
            remain = income - sum;
            remainShow.Text = "本月餘額:  " + remain.ToString() + "元";
            /*if (remain < 0)
            {
                remain = income + int.Parse(incomeInput.Text);
                remainShow.Text = "本月餘額:  " + remain.ToString() + "元";

            }*/
        }

        private void enterSpendButton_Click(object sender, EventArgs e)
        {
            spend = new Money(spendCategory.SelectedItem.ToString(), int.Parse(spendInput.Text));
            categoryIndex[spendCategory.SelectedIndex] += spend.Spend;
            sum += spend.Spend;
            remain = income - sum;


            remainShow.Text = "本月餘額:  " + remain.ToString() + "元";
            spendShow.Text = "本月開銷:  " + sum.ToString() + "元";
            if (remain < income / 2 && remain > income / 3)
            {
                MessageBox.Show("已經花超過收入的二分之一囉! 省點錢(´; ω;`)");
                warning.Text = "小提醒: 已經花超過收入的二分之一囉!";

            }
            if ((remain == income / 3 || remain< income / 3) && remain > 0)
            {
                MessageBox.Show("已經花超過收入的三分之二囉! 月底要吃土啦ΩДΩ");
                warning.Text = "小提醒: 已經花超過收入的三分之二囉!";
            }
            if (remain == 0 || remain < 0)
            {
                MessageBox.Show("已經沒有錢囉! 快去賺錢吧(✪ω✪)");
                warning.Text = "小提醒: 已經沒有餘額，請重新輸入您的收入!";

            }
        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {
            categorySpend = categoryIndex[spendCatergoryShow.SelectedIndex];
            spendCateMoney.Text = categorySpend.ToString() + " 元";

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
