using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Track_My_Shows
{
    class TestColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Transparent; }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Black;
            }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Transparent;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Transparent;
            }
        }

       

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Transparent; }
        }

        

        
        
    }
}
