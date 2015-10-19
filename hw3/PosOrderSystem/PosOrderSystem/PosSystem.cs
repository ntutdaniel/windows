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
    public partial class OrderSystem : Form
    {
        private const int TOTAL_MEAL = 15;
        private const int ROW = 3;
        private const int COLUMN = 3;
        private const int MAX_MEAL_PAGE = ROW * COLUMN;
        private const int MAX_PAGE = 2;
        private int _buttonIndex = 0;//0代表前一頁,1代表下一頁
        private MealButtonList _meal;
        private ControlPage _controlPage;
        private OrderList _orderList;
        private OrderModel _orderGridView;
        private MealData _mealData;//接收StartUpView的資料

        public OrderSystem(MealData mealData)
        {
            _mealData = mealData;
            InitializeComponent();
            InitialMealButton();
            InitialMealButtonClick();
            InitialMealGroup();
            InitialGridView();
            _controlPage = new ControlPage();
            _orderList = new OrderList();
            _controlPage.CheckButton(_previousPageButton, _nextPageButton);
            _controlPage.InitialPage(MAX_PAGE, MAX_MEAL_PAGE, TOTAL_MEAL, _pageNumberLabel);
            _controlPage.InitialMealButton(_meal);
        }

        //下一頁按鈕觸發事件(控制顯示哪些餐點&控制上下頁按鈕是否能動作)
        private void ClickNextPageButton(object sender, EventArgs e)
        {
            _buttonIndex = 1;
            _controlPage.ClickPageButton(_buttonIndex, _pageNumberLabel, _meal);
            _controlPage.CheckButton(_previousPageButton, _nextPageButton);
        }

        //上一頁按鈕觸發事件(控制顯示哪些餐點&控制上下頁按鈕是否能動作)
        private void ClickPreviousPageButton(object sender, EventArgs e)
        {
            _buttonIndex = 0;
            _controlPage.ClickPageButton(_buttonIndex, _pageNumberLabel, _meal);
            _controlPage.CheckButton(_previousPageButton, _nextPageButton);
        }

        //初始化GridView
        private void InitialGridView()
        {
            _orderGridView = new OrderModel(_mealRecordDataGridView);
            _orderGridView.InitialDataGridView();
            _mealRecordDataGridView.CellContentClick += OrderCellContentClick;
            _mealRecordDataGridView.CellValueChanged += OrderDataGridViewCellValueChanged;
        }

        //dataGridView click觸發事件
        private void OrderCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < _mealRecordDataGridView.Rows.Count)
            {
                string meal_name = _mealRecordDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                _orderList.DeleteItem(meal_name);
                UpdateDataGridView();
                ShowTotalPrice();
            }
        }

        //dataGridView 值改變時的觸發事件
        private void OrderDataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int mealQuantity = Convert.ToInt16(_mealRecordDataGridView.Rows[e.RowIndex].Cells[3].Value);
            string mealName = _mealRecordDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            _orderList.SearchItem(mealName).SetItemQuantity(mealQuantity);
            UpdateDataGridView();
            ShowTotalPrice();
        }

        //初始化meal按鈕
        private void InitialMealButton()
        {
            _meal = new MealButtonList();
            for (int mealIndex = 0; mealIndex < TOTAL_MEAL; mealIndex++)
            {
                _meal.AddMeal(_mealData.GetMeal(mealIndex).GetName(), _mealData.GetMeal(mealIndex).GetPrice(), _mealData.GetMeal(mealIndex).GetDescription());
            }
        }

        //給予每個點餐按鈕Click事件
        private void InitialMealButtonClick()
        {    
            for (int mealIndex = 0; mealIndex < TOTAL_MEAL; mealIndex++)
            {              
                _meal.GetMealButton(mealIndex).Click += MealButtonClicked;
                _meal.GetMealButton(mealIndex).MouseEnter += EnterMouseEnter;
                _meal.GetMealButton(mealIndex).MouseLeave += LeaveMouseLeave;
            }
        }

        //按鈕之觸發事件function(顯示餐點描述到RichTextBox)
        void EnterMouseEnter(object sender, System.EventArgs e)
        {
            _mealDescriptionRichTextBox.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            _mealDescriptionRichTextBox.Text = ((MealButton)sender).GetButtonDescription();
        }

        //當滑鼠離開button時取消顯示
        void LeaveMouseLeave(object sender, System.EventArgs e)
        {
            _mealDescriptionRichTextBox.Text = "";
        }

        //按鈕之觸發事件function(給資料到清單內&給資料到Gridview裡面)
        void MealButtonClicked(object sender, EventArgs e)
        {
            if (!(_orderList.CheckItemAndAdd(((MealButton)sender).GetButtonName())))
            {
                _orderList.AddItem(((MealButton)sender).GetButtonName(), ((MealButton)sender).GetButtonPrice());
            }

            UpdateDataGridView();
            ShowTotalPrice();
        }
        
        //更新dataGridView
        void UpdateDataGridView()
        {
            _mealRecordDataGridView.Rows.Clear();
            for (int rowIndex = 0; rowIndex < _orderList.GetItemCount(); rowIndex++)
            {
                string[] itemData = { "X", _orderList.GetItem(rowIndex).GetItemName(), Convert.ToString(_orderList.GetItem(rowIndex).GetItemUnitPrice()), Convert.ToString(_orderList.GetItem(rowIndex).GetItemQuantity()), Convert.ToString(_orderList.GetItem(rowIndex).GetItemTotal()) };
                _mealRecordDataGridView.Rows.Add(itemData);
            }
        }

        //計算消費總額
        void ShowTotalPrice()
        {
            int total = 0;
            for (int itemIndex = 0; itemIndex < _orderList.GetItemCount(); itemIndex++)
            {
                total += _orderList.GetItem(itemIndex).GetItemTotal();
            }
            _totalLabel.Text = "Tatal :" + " " + Convert.ToString(total) + " NTD";
        }

        //放置按鈕到GroupBox上面
        private void InitialMealGroup()
        {
            for (int mealIndex = 0; mealIndex < TOTAL_MEAL; mealIndex++)
            {
                _mealTableLayoutPanel.Controls.Add(_meal.GetMealButton(mealIndex), mealIndex % COLUMN, mealIndex / COLUMN % ROW);
            }
        }
    }

}
