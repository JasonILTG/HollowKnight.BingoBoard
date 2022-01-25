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

            entries.Add(new IMenuMod.MenuEntry
            {
                Name = "Notify:",
                Description = "Toggle sound notifications for board updates",
                Values = new string[] {"On", "Off"},
                Saver = SetNotifyState,
                Loader = GetNotifyState
            });

            return entries;
        }

        public void SetNotifyState(int i)
        {
            globalSettings.notify = i == 0;
        }

        public int GetNotifyState()
        {
            if (globalSettings.notify) return 0;
            return 1;
        }
    }
}
