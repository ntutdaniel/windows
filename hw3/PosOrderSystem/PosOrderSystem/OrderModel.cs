using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosOrderSystem
{
    class OrderModel
    {
        private const int TITLE_NAME_NUMBER = 1;
        private const int TITLE_PRICE_NUMBER = 2;
        private const int TITLE_AMOUNT_NUMBER = 3;
        private const int TITLE_TOTAL_MONEY_NUMBER = 4;
        private const String TYPE = "標楷體";

        private DataGridView _foodItemDataGridView;

        public OrderModel(DataGridView foodItemDataGridView)
        {
            this._foodItemDataGridView = foodItemDataGridView;
        }

        //  初始化表格
        public void InitialDataGridView()
        {
            _foodItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            _foodItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _foodItemDataGridView.RowHeadersVisible = false;
            _foodItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            _foodItemDataGridView.Font = new System.Drawing.Font(TYPE, 12F, System.Drawing.FontStyle.Bold);
        }
    }
}
public class OrderItem
{
    private string _name;
    private int _unitPrice;
    private int _quantity;
    public OrderItem()
    {
        _unitPrice = 0;
        _quantity = 1;
    }

    //設定帳單項目
    public void SetItem(string name, int price)
    {
        _name = name;
        _unitPrice = price;
    }

    //設定帳單餐點數量
    public void SetItemQuantity(int quantity)
    {
        _quantity = quantity;
    }

    //取得帳單餐點名稱
    public string GetItemName()
    {
        return _name;
    }

    //取得餐點單價
    public int GetItemUnitPrice()
    {
        return _unitPrice;
    }

    //取的餐點數量
    public int GetItemQuantity()
    {
        return _quantity;
    }

    //增加餐點數量
    public void AddItemQuantity()
    {
        _quantity++;
    }

    //取得該餐點是消費金額
    public int GetItemTotal()
    {
        return _unitPrice * _quantity;
    }

}

public class OrderList
{
    private List<OrderItem> _orderItem;
    private OrderItem _tempItem;
    private int _itemIndex;
    public OrderList()
    {
        _itemIndex = 0;
        _orderItem = new List<OrderItem>();
        _tempItem = new OrderItem();
    }

    //添加餐點至清單中
    public void AddItem(string name, int price)
    {
        _tempItem = new OrderItem();
        _tempItem.SetItem(name, price);
        _orderItem.Add(_tempItem);
        _itemIndex++;//紀錄有幾個餐點在清單內
    }

    //清單內餐點重複回傳true
    public bool CheckItemAndAdd(string name)
    {
        for (int itemIndex = 0; itemIndex < _orderItem.Count; itemIndex++)
        {
            if (_orderItem[itemIndex].GetItemName().Equals(name))
            {
                _orderItem[itemIndex].AddItemQuantity();
                return true;
            }
        }
        return false;
    }

    //刪除清單內之指定餐點
    public void DeleteItem(string name)
    {       
        for (int itemIndex = 0; itemIndex < _orderItem.Count(); itemIndex++)
        {
            if (_orderItem[itemIndex].GetItemName().Equals(name))
            {
                _orderItem.RemoveAt(itemIndex);
            }
        }
        _itemIndex--;
    }
    
    //搜尋特定餐點並回傳餐該餐點
    public OrderItem SearchItem(string name)
    {
        int index = 0;
        for (int itemIndex = 0; itemIndex < _orderItem.Count(); itemIndex++)
        {
            if (_orderItem[itemIndex].GetItemName().Equals(name))
            {
                index = itemIndex;
            }
        }
        return _orderItem[index];
    }

    //回傳點餐清單之特定項目
    public OrderItem GetItem(int index)
    {
        return _orderItem[index];
    }

    //回傳清單內總共有多少個菜色
    public int GetItemCount()
    {
        return _itemIndex;
    }
}
