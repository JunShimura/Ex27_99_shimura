using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    /// <summary>
    /// 三角形
    /// </summary>
    class Triangle
    {
        private float width;    //　幅
        private float height;   //　高さ
        private float[] sideLength = new float[3];
        private float _surface;  // コンストラクタで代入
        public float surface
        {   // 外部から読み取りだけできる変数
            get
            {
                return _surface;
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        public Triangle(float w, float h)
        {
            this.width = w;
            this.height = h;
            _surface = width * height / 2;
        }
        public Triangle(float side1, float side2, float side3)
        {
            this.sideLength[0] = side1;
            this.sideLength[1] = side2;
            this.sideLength[2] = side3;
            float s = (sideLength[0] + sideLength[1] + sideLength[2]) / 2;
            _surface = MathF.Sqrt(s * (s - sideLength[0]) * (s - sideLength[1]) * (s - sideLength[2]));
        }
        /// <summary>
        /// 面積を取得
        /// </summary>
        /// <returns>面積</returns>
        public float GetSurface()
        {
            return _surface;
        }
    }
}