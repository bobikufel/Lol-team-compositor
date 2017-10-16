using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_team_compositor
{
    class Champion
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public System.Drawing.Bitmap Img { get; private set; }
        public bool Toplane { get; private set; }
        public bool Jungle { get; private set; }
        public bool Midlane { get; private set; }
        public bool Marksman { get; private set; }
        public bool Support { get; private set; }
        public bool zajety=false;
        public Champion(string name, System.Drawing.Bitmap img, bool toplane, bool jungle, bool midlane, bool marksman, bool support)
        {            
            Name = name;
            Img = img;
            Toplane = toplane;
            Jungle = jungle;
            Midlane = midlane;
            Marksman = marksman;
            Support = support;

        }

    }
}
