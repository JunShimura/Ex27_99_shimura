using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtility
{
    /// <summary>
    /// Consoleへ特定の指定で出力
    /// </summary>
    class ConsoleOut
    {
        /// <summary>
        /// 文字列を指定された色でConsoleへ出力
        /// </summary>
        /// <param name="s">文字列</param>
        /// <param name="c">色</param>
        public static void OutputColoredText(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}

