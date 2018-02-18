
using System;

namespace AdventOfCode.Y2017 {

    class SplashScreenImpl : AdventOfCode.SplashScreen {

        public void Show() {

            var color = Console.ForegroundColor;
            Write(ConsoleColor.Yellow, "\n  __   ____  _  _  ____  __ _  ____     __  ____     ___  __  ____  ____         \n / _\\ (    \\/ )( ");
            Write(ConsoleColor.Yellow, "\\(  __)(  ( \\(_  _)   /  \\(  __)   / __)/  \\(    \\(  __)        \n/    \\ ) D (\\ \\/ / ) _) /    /  )( ");
            Write(ConsoleColor.Yellow, "   (  O )) _)   ( (__(  O )) D ( ) _)         \n\\_/\\_/(____/ \\__/ (____)\\_)__) (__)    \\__/(__)     \\");
            Write(ConsoleColor.Yellow, "___)\\__/(____/(____)  2017\n\n           ");
            Write(ConsoleColor.DarkGray, "|O|        Naughty      |        Nice         |O|       \n           |O|  -------------------+-------");
            Write(ConsoleColor.DarkGray, "------------  |O|       \n           |O|  The Easter Bunny   | encse               |O|       \n       ");
            Write(ConsoleColor.DarkGray, "    |O|  Mate Borcsok       | Csaba Okrona        |O|       \n           |O|  abesto             | si");
            Write(ConsoleColor.DarkGray, "klosid            |O|       \n           |O|  mrisoli            | Marcell Endrey      |O|       \n   ");
            Write(ConsoleColor.DarkGray, "        |O|  vigoo              | Róbert Bán          |O|       \n           ");
            Write(ConsoleColor.Gray, ".-----------------------------------------------.       \n           | ");
            Write(ConsoleColor.DarkGray, "┌────────────");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┐o─────┬─┐┌───────┬────────o ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "25 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└─┐o────┐");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┘o──┴──────┘V│└┐o─────┘┌───────┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "24 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "o─┴─────┘└───────");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o─┬┘└┐└───────┴──o┌───┤ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "23 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "V┌");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "────");
            Write(ConsoleColor.Blue, "┤|├");
            Write(ConsoleColor.DarkGray, "─────");
            Write(ConsoleColor.Magenta, "oTo");
            Write(ConsoleColor.DarkGray, "──┐└─┐└──┴───────");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "──┘o──┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "22 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└┘└──────");
            Write(ConsoleColor.Magenta, "oTo");
            Write(ConsoleColor.DarkGray, "─");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o────┐└─┐└───────────────");
            Write(ConsoleColor.Green, "|(");
            Write(ConsoleColor.DarkGray, "───┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "21 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───────");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "─┐└────┐└──┴────────────");
            Write(ConsoleColor.Green, "|(");
            Write(ConsoleColor.DarkGray, "───────┤ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "20 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "├──────┐o───┴─");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "┘┌───────┬────");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o─────────┐│ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "19 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└─────┐└───");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "─────┴┬──o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─┐└─o┌─┘┌─");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "─────┘│ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "18 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌──┬─o├─");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "──o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "──┐┌┴┴┴┴┴┬┴───┘o─┴────┐┌────┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "17 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└─o└──┘");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───────┘o┐└┤     ├┐o┬────┬┴┴┴┴┤└┐o──┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "16 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌──────┘┌");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o────┬─┴─┤   P ├└─┘┌───┤    ├─┘┌──┤ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "15 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└───────┘├┴┴┴┬");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "└───┤   R0├───┴───┤    ├┌─┘o─┤ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "14 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "────────┤ P0├└────┤   23├──┐┌───┤ HCF├└───┐= ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "13 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "├──┐┌");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o──┤ R2├─────┤   AG├──┘└───┴┬┬┬┬┴───┐└┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "12 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "│┌┐└┘└───┤ 2-├──");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o─┴┬┬┬┬┬┴─┐┌─o┌┴┴┴┴┬─┬──o│┌┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "11 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└┘└──o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "──┤ CG├─┐└───┬┴┴┴┼─┐└┘┌─┤  we├┐└───┘└┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "10 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─────┘o─┤   ├─┴────┤   ├o└──┴─┤  h(├┴─");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "─┤ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 9 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└──");
            Write(ConsoleColor.Green, "|(");
            Write(ConsoleColor.DarkGray, "────┴┬┬┬┴──────┤   ├────");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "┌┤  i1├─────┬o│ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 8 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌─────────");
            Write(ConsoleColor.Magenta, "oTo");
            Write(ConsoleColor.DarkGray, "─┐┌────┤   ├");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┘└┤  l)├────o└─┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 7 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "├─────┐o─┬────┘└──┐┌┴┬┬┬┘└─────┴┬┬┬┬┴───────");
            Write(ConsoleColor.Yellow, "* ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 6 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└────o└─┐└─");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "────┘└─┘└──────────────┐");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─────┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 5 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌───────┘┌─");
            Write(ConsoleColor.Red, "[─]");
            Write(ConsoleColor.DarkGray, "────┐┌────┬───┐┌───────┘└─────");
            Write(ConsoleColor.Yellow, "* ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 4 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "├────────┴──o┌────┤│o──┐└──┐=├────────o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "────┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 3 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└┐o──┐┌──────┘o───┘└─┬─┴──o└─┘");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───────┐└────┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 2 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "o┴───┘└─");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "──────────┘");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───────┘o──────┴─────┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 1 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "'-----------------------------------------------'       \n           \n");
            
            Console.ForegroundColor = color;
            Console.WriteLine();
        }

       private static void Write(ConsoleColor color, string text){
           Console.ForegroundColor = color;
           Console.Write(text);
       }
    }
}