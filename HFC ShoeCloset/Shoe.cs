using System;
using System.Collections.Generic;
using System.Text;

namespace HFC_ShoeCloset
{
 public   class Shoe
    {
        public string colour; public Styles style;
        public string describeShoe { get { return $"a pair of {colour} {style}"; } }
        public Shoe(string Colour, Styles Style)
        {
            this.colour = Colour;
            this.style = Style;
            //this.describeShoe = $"a {colour} {style}";

        }

    }

/*public    enum Colours
    {
        black, 
        brown,
        blue,
        red,
        white,
        green
    }
*/
public    enum Styles
    {
        trainers,
        loafers,
        sandals,
        flipflops,
        wingtips,
        clogs,
    }
}
