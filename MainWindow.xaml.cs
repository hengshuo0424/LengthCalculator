﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LengthCalculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM
            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果
            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtInfo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtKM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtIn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtFt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtYard_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtInfo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtCM_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
