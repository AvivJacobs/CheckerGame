using System;
using System.Collections.Generic;
using System.Text;

namespace B18_Ex05
{
    // $G$ RUL-005 (-10) Wrong zip folder name: 2 spaces between first student and his id
    public class Program
    {
        // $G$ SFN-013 (+18) Bonus: UI with richer graphics / motion / sound.

        public static void Main()
        {
            UserInteraction UI = new UserInteraction();
            UI.RunGame();
        }
    }
}