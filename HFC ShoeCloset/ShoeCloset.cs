using System;
using System.Collections.Generic;
using System.Text;

namespace HFC_ShoeCloset
{
    class ShoeCloset
    {
        public List<Shoe> closetContents = new List<Shoe>();

        public void AddShoe()
        {
            Console.WriteLine("\n<<ADD A SHOE>>\n");
            /* Console.WriteLine("Press 0 to add some trainers\n" +
                 "Press 1 to add some loafers\n" +
                 "Press 2 to add some sandals\n" +
                 "Press 3 to add some flipflops\n" +
                 "Press 4 to add some wingtips\n");
          

            foreach (Colours colour in Enum.GetValues(typeof(Colours)))
            {
                styleMenu.Append($"Press {colour}");
            }  */            
            StringBuilder styleMenu = new StringBuilder();
            int stycount =0;
            foreach (Styles styles in Enum.GetValues(typeof(Styles)))
            {
                styleMenu.Append($"Press {stycount} to add some {styles}\n");
                stycount++;
            }
            stycount = 0;
            Console.WriteLine(styleMenu);
            Console.WriteLine("Enter a number...");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.WriteLine($"\nWhat colour are the {(Styles)style}?");
                string selectedColour = Console.ReadLine().ToLower();
                Shoe newShoe = new Shoe(selectedColour, (Styles)style);
                closetContents.Add(newShoe);
            }

        }

        public void DisplayClosetList()
        {
            if (closetContents.Count == 0) Console.WriteLine("\nThe shoe closet is empty"); ;
            //this 'return' exits the Method before the string is built
            StringBuilder displayedClosetList = new StringBuilder();
            for (int i = 1; i <= closetContents.Count; i++)
            {
                displayedClosetList.Append($"\n#{i}: {closetContents[i - 1].describeShoe}");                
            }
            Console.WriteLine(displayedClosetList.ToString()); ;
        }

        public void RemoveShoe()
        {
            Console.WriteLine("Which number shoe do you which to remove?");
            DisplayClosetList();
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int toDelete))
                closetContents.RemoveAt(toDelete - 1);
        }

        public void DisplayOptions()
        {
            DisplayClosetList();
            Console.WriteLine("Press 'a' to add, or 'r' to remove");
            char key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case 'a':
                case 'A':
                    AddShoe();
                    break;
                case 'r':
                case 'R':
                    RemoveShoe();
                    break;
                default:
                    return;
            }
        }

        
        
    }
}
