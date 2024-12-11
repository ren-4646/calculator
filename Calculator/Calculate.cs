using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorusing

{

   public class Calculate
    {
        public double dNum_Pool { get; private set; }
        public enum MarksType 
        { 
            EQUAL,
            PLUS,
            MINUS,
            MULTIPLIED,
            DEVIDED,
            PERCENT
        }
        public MarksType mType = MarksType.EQUAL;
        public void SetOperation(MarksType type)
        { 
            mType = type; 
        }
        public double Calculation(double dNum)
        { 
            // ログの書き込み処理が必要
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
                // 小数点は5桁まで操作可能とする必要あり
                case MarksType.DEVIDED:
                    dNum_Pool /= dNum; 
                    break;
            } 
            mType = MarksType.EQUAL;
            return dNum_Pool;
        }
    }
}

