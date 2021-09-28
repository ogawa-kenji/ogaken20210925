using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGA
{
    public class Calc
    {
        /// <summary>
        /// 四捨五入
        /// </summary>
        /// <param name="val"></param>
        /// <param name="digits"></param>
        /// <returns>
        /// 四捨五入
        /// プラス値、マイナス値
        /// 0.5→1.0、-0.5→-1.0
        /// 四捨五入するメソッド
        /// </returns>
        public decimal Round(decimal val,int digits)
        {

            if (val == 0m) return val;
            
            var coefficient = Convert.ToDecimal(System.Math.Pow(10, digits));
            var sign = System.Math.Sign(val);

            return System.Math.Floor((System.Math.Abs(val) * coefficient) + 0.5m) / coefficient * sign;
            
        }
    }
}
