using System;
using System.Collections.Generic;
using System.Linq;

using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(5, 3.5f);
            Console.WriteLine($"面積は{triangle1.surface}");
            Console.WriteLine("三角形ABCの各辺の長さを入力してください");
            float[] l = new float[3];
            while (true)
            {
                l[0] = InteractiveInput.InputFloat(float.MaxValue, 0, "辺0の長さ：");
                l[1] = InteractiveInput.InputFloat(float.MaxValue, 0, "辺1の長さ：");
                l[2] = InteractiveInput.InputFloat(float.MaxValue, 0, "辺2の長さ：");
                if (l.Max() >= l.Sum() / 2)
                {
                    Console.WriteLine("三角形になりません");
                }
                else
                {
                    break;
                }
            }
            Triangle triangle2 = new Triangle(l[0], l[1], l[2]);
            Console.WriteLine($"面積は{triangle2.surface}");
            // triangle2.surface = 10; コンパイルエラー
        }
    }
}
