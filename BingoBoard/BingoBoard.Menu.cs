using System.Collections.Generic;
using Modding;

namespace BingoBoard
{
    public partial class BingoBoard : IMenuMod
    {
        public bool ToggleButtonInsideMenu => false;

        public List<IMenuMod.MenuEntry> GetMenuData(IMenuMod.MenuEntry? toggleButtonEntry)
        {
            List<IMenuMod.MenuEntry> entries = new List<IMenuMod.MenuEntry>();

            return entries;
        }
    }
}
