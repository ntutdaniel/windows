using System;
using System.IO;
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
    public class ControlPage
    {
        private int _totalPage;
        private int _currentPage;
        private int _perPageButtonNumber;
        private int _totalButtonNumber;
        private const string PAGE_STRING = "Page : ";
        private const string SLASH = " / ";
        public ControlPage()
        {
            _currentPage = 1;
        }

        //初始化page按鈕&頁數顯示標籤
        public void InitialPage(int totalPage, int perPageButtonNumber, int totalButtonNumber, Label pageNumberLabel)
        {
           
            _perPageButtonNumber = perPageButtonNumber;
            _totalButtonNumber = totalButtonNumber;
            _totalPage = totalPage;

            pageNumberLabel.Text = PAGE_STRING + Convert.ToSingle(_currentPage) + SLASH + Convert.ToString(_totalPage);
        }

        //初始化點餐按鈕
        public void InitialMealButton(MealButtonList mealList)
        {
            ControlButtonVisible(mealList);
        }

        //換頁按鈕觸發以及顯示頁數
        public void ClickPageButton(int buttonIndex, Label pageNumberLabel, MealButtonList mealList)
        {
            if (buttonIndex == 0 && _currentPage > 1)
            {
                _currentPage--;
                ControlButtonVisible(mealList);
                pageNumberLabel.Text = PAGE_STRING + Convert.ToSingle(_currentPage) + SLASH + Convert.ToString(_totalPage);
            }
            else if (buttonIndex == 1 && _currentPage < _totalPage)
            {
                _currentPage++;
                ControlButtonVisible(mealList);
                pageNumberLabel.Text = PAGE_STRING + Convert.ToSingle(_currentPage) + SLASH + Convert.ToString(_totalPage);
            }
        }

        //初始化點餐按鈕(判斷哪些按鈕需要顯示)
        void ControlButtonVisible(MealButtonList mealList)
        {
            int maxButtonIndex;
            int minButtonIndex;
            int buttonIndex;
            minButtonIndex = (_currentPage - 1) * _perPageButtonNumber;
            maxButtonIndex = _currentPage * _perPageButtonNumber;
            for (buttonIndex = 0; buttonIndex < _totalButtonNumber; buttonIndex++)
            {
                if (minButtonIndex <= buttonIndex && buttonIndex < maxButtonIndex)
                {
                    mealList.GetMealButton(buttonIndex).Visible = true;
                }
                else
                    mealList.GetMealButton(buttonIndex).Visible = false;
            }
        }

        //判斷換頁按鈕是否超過範圍
        public void CheckButton(Button previousButton, Button nextButton)
        {
            if (_currentPage <= 1)
            {
                previousButton.Enabled = false;
                nextButton.Enabled = true;
            }
            else if (_currentPage >= _totalPage - 1)
            {
                previousButton.Enabled = true;
                nextButton.Enabled = false;
            }
        }
    }
}

public class MealButton : Button
{
    private int _price;
    private string _name;
    private string _description;
    private string _path;

    public MealButton()
    {
        _price = 0;
    }

    //設定按鈕值
    public void SetButton(string name, int price, string description, string path)
    {
        _name = name;
        _price = price;
        _description = description;
        _path = path;
    }

    //取得按鈕餐點名稱
    public string GetButtonName()
    {
        return _name;
    }

    //取得按鈕餐點價錢
    public int GetButtonPrice()
    {
        return _price;
    }

    //取得餐點描述
    public string GetButtonDescription()
    {
        return _description;
    }

    //取得餐點圖片路徑
    public string GetButtonPath()
    {
        return _path;
    }
}

public class MealButtonList
{
    private List<MealButton> _mealList;
    private const string ENTER_STRING = "\n";
    private const string SPACE_STRING = " ";
    private const string DOLLAR_STRING = "NTD";
    private const string IMAGE_PATH_NAME = "\\meal photo\\";
    private const string IMAGE_FORMAT = ".jpeg";
    private const String TYPE = "標楷體";
    private const int WIDTH = 170;
    private const int HEIGHT = 110;
    public MealButtonList()
    {
        _mealList = new List<MealButton>();
    }

    //新增菜單以及初始化按鈕屬性
    public void AddMeal(string name, int price, string description)
    {
        MealButton newMealButton = new MealButton();
        string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        string imagePath = name + IMAGE_FORMAT;
        newMealButton.Visible = false;
        newMealButton.Dock = System.Windows.Forms.DockStyle.Fill;
        newMealButton.Text = name + ENTER_STRING + Convert.ToString(price) + SPACE_STRING + DOLLAR_STRING;
        newMealButton.Font = new System.Drawing.Font(TYPE, 12F, System.Drawing.FontStyle.Bold);
        newMealButton.TextAlign = ContentAlignment.TopRight;
        newMealButton.SetButton(name, price, description,projectPath + IMAGE_PATH_NAME + name + IMAGE_FORMAT);
        newMealButton.BackgroundImage = Image.FromFile(projectPath + IMAGE_PATH_NAME + name + IMAGE_FORMAT);
        var tempImage = new Bitmap(newMealButton.BackgroundImage, new Size(WIDTH, HEIGHT));
        newMealButton.BackgroundImage = tempImage;
        _mealList.Add(newMealButton);
    }

    //刪除餐點
    public void DeleteMeal(String name)
    {
        for (int mealIndex = 0; mealIndex < _mealList.Count(); mealIndex++)
        {
            if (_mealList[mealIndex].GetButtonName().Equals(name))
            {
                _mealList.RemoveAt(mealIndex);
                break;
            }
        }
    }

    //取得按鈕(餐點)資料
    public MealButton GetMealButton(int mealIndex)
    {
        return _mealList[mealIndex];
    }
}

