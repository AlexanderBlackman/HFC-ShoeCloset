using System;
using System.Collections.Generic;
using System.Text;

namespace HFC_ShoeCloset
{
    class Shoe
    {
        public Colours colour; public Styles style;
        public string describeShoe;
        Shoe(Colours Colour, Styles Style)
        {
            this.colour = Colour;
            this.style = Style;
            //this.describeShoe = $"a {colour} {style}";

        }

    }

public    enum Colours
    {
        black, 
        brown,
        blue,
        red,
        white,
        green
    }

public    enum Styles
    {
        Trainers,
        Loafer,
        Sandal,
        Flipflop,
        Wingtip,
        Clogs,
    }
}
