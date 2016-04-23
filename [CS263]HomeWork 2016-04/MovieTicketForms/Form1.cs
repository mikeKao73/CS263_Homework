using DiscountLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketForms
{
    public partial class Form1 : Form
    {
        // private List<Discount> dicounts;
        private static double totalPrice = 0;

        // private static bool clearDetailRichTextBox = false;

        public Form1()
        {
            InitializeComponent();
            UpdateMovieTicketInfo();
        }

        private void UpdateMovieTicketInfo()
        {
            //if (clearRichTextBox == true)
            //{
            //    detailRichTextBox.Text = string.Empty;
            //    clearRichTextBox = !clearRichTextBox;
            //}

            discountComboBox.Items.Clear();
            switch (typeOfTicketComboBox.SelectedIndex)
            {
                case 0:   //全票
                    discountComboBox.Items.Insert(0, "現金付款");
                    discountComboBox.Items.Insert(1, "刷VIP卡優惠");
                    discountComboBox.Text = string.Empty;

                    break;

                case 1:   //學生票
                    discountComboBox.Items.Insert(0, "學生證優惠");
                    discountComboBox.Text = string.Empty;
                    break;

                case 2:   //兒童票
                    discountComboBox.Items.Insert(0, "小學生證優惠");
                    discountComboBox.Items.Insert(1, "5歲以下嬰兒優惠");
                    discountComboBox.Text = string.Empty;
                    break;

                default:
                    discountComboBox.Text = string.Empty;
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Discount aDiscount = new Discount();
            CheckComboBoxItem();
            NoDicount noDiscount = new NoDicount();
            BabyDiscount aBabyDiscount = new BabyDiscount();
            StudentDiscount aStudentDiscount = new StudentDiscount();
            VIPDiscount aVipDiscount = new VIPDiscount();
            ChildrenDiscount aChildrenDiscount = new ChildrenDiscount();

            if (typeOfTicketComboBox.SelectedIndex == 0 &&
                discountComboBox.SelectedIndex == 0)
                PrintOrder(noDiscount);
            else if (typeOfTicketComboBox.SelectedIndex == 0 &&
                discountComboBox.SelectedIndex == 1)
            {
                PrintOrder(aVipDiscount);
                detailRichTextBox.Text +=
                    aVipDiscount.gift(int.Parse(numberOfTicketComboBox.Text));
            }
            else if (typeOfTicketComboBox.SelectedIndex == 1 &&
                discountComboBox.SelectedIndex == 0)
                PrintOrder(aStudentDiscount);
            else if (typeOfTicketComboBox.SelectedIndex == 2 &&
                discountComboBox.SelectedIndex == 0)
                PrintOrder(aStudentDiscount);
            else if (typeOfTicketComboBox.SelectedIndex == 2 &&
             discountComboBox.SelectedIndex == 1)
                PrintOrder(aBabyDiscount);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            detailRichTextBox.Text = string.Empty;
            totalPrice = 0;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            detailRichTextBox.Text += "總計:" + totalPrice + "\n";
            detailRichTextBox.SelectionStart = detailRichTextBox.Text.Length;
            detailRichTextBox.ScrollToCaret();
            totalPrice = 0;
            //clearDetailRichTextBox = true;
        }

        private void numberOfTicketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private double GetPrice(Discount discount)
        {
            return discount.SetPrice();
        }

        private double GetCeaperPrice(Discount discount)
        {
            return (int)(GetPrice(discount) * discount.SetDiscount());
        }

        private void PrintOrder(Discount discount)
        {
            CheckComboBoxItem();
            double singlePrice;
            singlePrice = GetCeaperPrice(discount) * int.Parse(numberOfTicketComboBox.Text);
            totalPrice += singlePrice;
            detailRichTextBox.Text +=
                  "一張" + typeOfTicketComboBox.Text
                + "原價" + GetPrice(discount)
                + ",特價" + GetCeaperPrice(discount)
                + ",共" + numberOfTicketComboBox.Text + "張"
                + ",小計:" + singlePrice + "\n";
            detailRichTextBox.SelectionStart = detailRichTextBox.Text.Length;
            detailRichTextBox.ScrollToCaret();
        }

        private void CheckComboBoxItem()
        {
            if (typeOfTicketComboBox.Text == string.Empty)
                MessageBox.Show("請先選擇電影票類型");
            else if (discountComboBox.Text == string.Empty)
                MessageBox.Show("請先選擇電影票折扣");
            else if (numberOfTicketComboBox.Text == string.Empty)
                MessageBox.Show("請先選擇電影票張數");
            return;
        }

        private void typeOfTicketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMovieTicketInfo();
        }
    }
}