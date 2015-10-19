using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosOrderSystem
{
    public partial class StartUpView : Form
    {
        MealData _mealdata;
        OrderSystem form;
        public StartUpView()
        {
            InitializeComponent();
        }

        //打開前台點餐系統介面
        private void ClickFrontButton(object sender, EventArgs e)
        {
            _mealdata = new MealData();
            form = new OrderSystem(_mealdata);
            form.Show();
            _frontButton.Enabled = false;
            form.FormClosed += CloseCustomerForm;
        }

        //打開後台介面
        private void ClickBackButton(object sender, EventArgs e)
        {
            RestaurantView restaurantView = new RestaurantView();
            restaurantView.Show();
            _backButton.Enabled = false;
            restaurantView.FormClosed += CloseRestaurantForm;
        }

        //判斷後台介面是否為開啟狀態
        private void CloseRestaurantForm(Object sender, FormClosedEventArgs e)
        {
            _backButton.Enabled = true;
        }

        //判斷前台介面是否為開啟
        private void CloseCustomerForm(Object sender, FormClosedEventArgs e)
        {
            _frontButton.Enabled = true;
        }

        //結束按鈕事件
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
