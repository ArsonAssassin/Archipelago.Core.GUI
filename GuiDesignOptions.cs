using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archipelago.Core.GUI
{
    public class GuiDesignOptions
    {
        public string Title { get; set; }
        public Color? BackgroundColor { get; set; } = null;
        public Color? ButtonColor { get; set; } = null;
        public Color? ButtonTextColor { get; set; } = null;
        public Image CornerImage { get; set; }
        public Image BackgroundImage { get; set; }
        public Color? TextColor { get; set; } = null;
        public Icon Icon { get; set; }
    }
}
