using System.Collections.Generic;
using Modding;

namespace BingoBoard
{
    public partial class BingoBoard : IMenuMod
    {
        public List<IMenuMod.MenuEntry> GetMenuData(IMenuMod.MenuEntry? toggleButtonEntry)
        {
            List<IMenuMod.MenuEntry> entries = new List<IMenuMod.MenuEntry>();

            entries.Add(new IMenuMod.MenuEntry
            {
                Name = "Display Counters:",
                Description = "Toggle when to display the counters",
                Values = new string[] {"On Change", "Always", "Never" },
                Saver = SetDisplayState,
                Loader = GetDisplayState
            });

            return entries;
        }
    }
}
