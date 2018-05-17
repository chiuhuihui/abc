using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStatistic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 學生資料
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] bloodtype = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };

            // 男女生人數百分比
            double male = 0;
            double female = 0;
            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "男")
                {
                    male++;
                }
                else
                {
                    female++;
                }
            }

            // 第1題、第2題答案
            double malePercent = (male / (male + female) * 100);
            double femalePercent = (female / (male + female) * 100);

            // 血型人數百分比
            double btA = 0;
            double btB = 0;
            double btO = 0;
            double btAB = 0;
            double btOther = 0;
            for (int i = 0; i < bloodtype.Length; i++)
            {
                if (bloodtype[i] == "A")
                {
                    btA++;
                }
                else if (bloodtype[i] == "B")
                {
                    btB++;
                }
                else if (bloodtype[i] == "O")
                {
                    btO++;
                }
                else if (bloodtype[i] == "AB")
                {
                    btAB++;
                }
                else
                {
                    btOther++;
                }

            }

            // 第3題答案
            double APercent = (btA / bloodtype.Length) * 100;
            double BPercent = (btB / bloodtype.Length) * 100;
            double OPercent = (btO / bloodtype.Length) * 100;
            double ABPercent = (btAB / bloodtype.Length) * 100;
            double OtherPercent = (btOther / bloodtype.Length) * 100;

            // 男女生身高平均 全部身高平均
            double maleHei = 0;
            double femaleHei = 0;
            double totalHei = 0;
            double maleCount = 0;
            double femaleCount = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    totalHei += height[i];
                    if (gender[i] == "男")
                    {
                        maleHei += height[i];
                        maleCount++;
                    }
                    else
                    {
                        femaleHei += height[i];
                        femaleCount++;
                    }
                }
            }

            // 第5題、第6題、第7題答案
            double maleAvg = maleHei / maleCount;
            double femaleAvg = femaleHei / femaleCount;
            double totalAvg = totalHei / (maleCount + femaleCount);
            // 天蠍O型 第7題答案
            double zodiacO = 0;
            for (int i = 0; i < bloodtype.Length; i++)
            {
                if (bloodtype[i] == "O")
                {
                    if (zodiac[i] == "天蠍")
                    {
                        zodiacO++;
                    }
                }
            }

            // 第8題答案
            int highest = 0;
            int shortest = 200;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    if (height[i] > highest)
                    {
                        highest = height[i];
                    }

                    if (height[i] < shortest)
                    {
                        shortest = height[i];
                    }
                }
            }

            // 輸出
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("第一題\n男生比例" + Math.Round(malePercent, 1) + "%");
            Console.WriteLine("第二題\n女生比例" + Math.Round(femalePercent, 1) + "%");
            Console.WriteLine("第三題\nA、B、O、AB、其他血型比例依序是" + Math.Round(APercent, 1) + "%" + Math.Round(BPercent, 1) + "%" + Math.Round(OPercent, 1) + "%" + Math.Round(ABPercent, 1) + "%" + Math.Round(OtherPercent, 1) + "%");
            Console.WriteLine("第四題\n男生身高平均 = " + Math.Round(maleAvg, 1));
            Console.WriteLine("第五題\n女生身高平均 = " + Math.Round(femaleAvg, 1));
            Console.WriteLine("第六題\n全部身高平均 = " + Math.Round(totalAvg, 1));
            Console.WriteLine("第七題\n天蠍座又O型的總共有" + zodiacO + "人");
            Console.WriteLine("第八題\n最高的人" + highest + "最矮的人" + shortest);

            // 暫停畫面
            Console.ReadLine();
        }
    }
}
