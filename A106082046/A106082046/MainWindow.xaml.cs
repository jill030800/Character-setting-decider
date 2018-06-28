using System;
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

namespace A106082046
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

        string randomText(string[] array) 
        {
            Random rnd = new Random();
            int control = rnd.Next(0, array.Length);
            string answer = array[control];
            return answer;
        }

        private void placeBUTTON_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "在教室", "在異世界", "在粉色房間", "在草野間", "在游泳池旁", "在河堤邊", "在舞台上", "在廁所裡", "在道場上", "在床上", "在水樂園", "在冰淇淋店", "在健身房", "在廢墟", "在廚房", "在地板上", "在便利商店" };
            placeNAME.Text = randomText(names);
        }

        private void styleBUTTON_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "帶著貓耳", "穿著黑絲襪", "戴粉色髮帶", "頭長貓耳", "帶機車手套", "帶著金項鍊", "穿著膝上襪", "拿著衛生紙", "穿著比基尼", "穿著死庫水", "gamemaker", "穿著紅高跟鞋", "滿身是血", "臉上刀疤", "布滿血絲", "有黑色指甲", "綁著高馬尾", "綁著雙馬尾 " };
            styleNAME.Text = randomText(names);
        }

        private void moodBUTTON_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "悲傷的", "愉悅的", "憤怒的", "滿臉疑惑的", "興奮的", "困擾的", "尷尬的", "瘋狂的", "霸道的", "難過的", "幼稚的", "鬱悶的", "放鬆的", "羞澀的", "外向的", "好動的", "一臉正常的" };
            moodNAME.Text = randomText(names);
        }

        private void roleBUTTON_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "男子高中生", "女子高中生", "妖怪少年", "妖怪少女", "世新學子", "養樂多教授", "性感御姐", "國小幼女", "國小正太", "甜美OL", "肌肉猛男", "童年巨乳", "有錢總裁", "黑膚少年", "黑膚少女", "武裝羅莉", "周詮","系草帥哥" };
            roleNAME.Text = randomText(names);
        }
    }
}
