using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorusing

{

    class Calculate
    {
        //ラベルをdouble型に格納する変数
        private double dNum;

        //ラベルの数字をプールする変数
        private double dNum_Pool;
        public enum MarksType //列挙子
        {
            EQUAL,
            PLUS,
            MINUS,
            MULTIPLIED,
            DEVIDED,
            PERCENT
        }

        private MarksType mType = MarksType.EQUAL;

        // 演算子の計算処理
        public void Num_PoolMethod(string text)
        {
            dNum = double.Parse(text);
            switch (mType)
            {
                case MarksType.EQUAL:
                    dNum_Pool = dNum;
                    break;
                case MarksType.PLUS:
                    dNum_Pool += dNum;
                    break;
                case MarksType.MINUS:
                    dNum_Pool -= dNum;
                    break;
                case MarksType.MULTIPLIED:
                    dNum_Pool *= dNum;
                    break;
                case MarksType.DEVIDED:
                    dNum_Pool /= dNum;
                    Math.Round(dNum_Pool, 6);
                    break;
            }
            //表示を更新
            text = dNum_Pool.ToString();
        }
    }
}
