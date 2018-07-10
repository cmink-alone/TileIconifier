﻿using System.Drawing;
using System.Windows.Forms;
using TileIconifier.Skinning.Skins;

namespace TileIconifier.Skinning
{
    /// <summary>
    /// Provides the colors internally used by a <see cref="ToolStripSystemRendererEx"/>.
    /// </summary>
    internal class ToolStripSystemColorTable
    {
        private readonly BaseSkin _skin;        

        #region "Constructor"
        internal ToolStripSystemColorTable(BaseSkin pSkin)
        {
            _skin = pSkin;
        }
        #endregion          

        internal Color MenuBarBackColor { get { return _skin.ToolStripMenuBarBackColor; } }
        internal Color PopupBackColor { get { return _skin.ToolStripPopupBackColor; } }
        internal Color MenuBarBorderColor { get { return _skin.ToolStripMenuBarBorderColor; } }
        internal Color PopupBorderColor { get { return _skin.ToolStripPopupBorderColor; } }
        internal Color HighlightBackColor { get { return _skin.ToolStripHighlightBackColor; } }
        internal Color HighlightForeColor { get { return _skin.ToolStripHighlightForeColor; } }
        internal Color MenuBarForeColor { get { return _skin.ToolStripMenuBarForeColor; } }
        internal Color PopupForeColor { get { return _skin.ToolStripPopupForeColor; } }
        internal Color DisabledForeColor { get { return _skin.ToolStripDisabledForeColor; } }

        #region "Default colors"
        internal static Color DefaultMenuBarBackColor => SystemColors.MenuBar;
        internal static Color DefaultPopupBackColor => SystemColors.Menu;
        internal static Color DefaultMenuBarBorderColor => SystemColors.ControlDark;
        internal static Color DefaultPopupBorderColor => SystemColors.ControlDark;
        internal static Color DefaultHighlightBackColor => SystemColors.Highlight;
        internal static Color DefaultHighlightForeColor => SystemColors.HighlightText;
        internal static Color DefaultMenuBarForeColor => SystemColors.MenuText;
        internal static Color DefaultPopupForeColor => SystemColors.MenuText;
        internal static Color DefaultDisabledForeColor => SystemColors.GrayText;
        #endregion
    }
}
