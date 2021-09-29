using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGA
{
    public static class Calc
    {
        /// <summary>
        /// 四捨五入
        /// </summary>
        /// <param name="val">四捨五入する値</param>
        /// <param name="digits">丸める小数部桁数</param>
        /// <returns>
        /// 四捨五入
        /// 0.5→1.0、-0.5→-1.0
        /// 負の数は絶対値として丸める
        /// 四捨五入するメソッド
        /// </returns>
        public static decimal Round(decimal val,int digits)
        {

            if (val == 0m) return val;
            
            var coefficient = Convert.ToDecimal(System.Math.Pow(10, digits));
            var sign = System.Math.Sign(val);

            return System.Math.Floor((System.Math.Abs(val) * coefficient) + 0.5m) / coefficient * sign;
        }

        /// <summary>
        /// 切り上げ
        /// </summary>
        /// <param name="val">切り上げする値</param>
        /// <param name="digits">丸める小数部桁数</param>
        /// <returns>
        /// 切り上げ
        /// 
        /// </returns>
        public static decimal RoundUp(decimal val, int digits)
        {

            if (val == 0m) return val;

            var coefficient = Convert.ToDecimal(System.Math.Pow(10, digits));
            var sign = System.Math.Sign(val);

            return System.Math.Ceiling(System.Math.Abs(val) * coefficient) / coefficient * sign;
        }

        /// <summary>
        /// 切り捨て
        /// </summary>
        /// <param name="val">切り捨てする値</param>
        /// <param name="digits">丸める小数部桁数</param>
        /// <returns>
        /// 切り上げ
        /// 
        /// </returns>
        public static decimal RoundDown(decimal val, int digits)
        {

            if (val == 0m) return val;

            var coefficient = Convert.ToDecimal(System.Math.Pow(10, digits));
            var sign = System.Math.Sign(val);

            return System.Math.Floor(System.Math.Abs(val) * coefficient) / coefficient * sign;
        }

    }
}
