using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Modding;
using UnityEngine.SceneManagement;

namespace BingoBoard
{
    public partial class BingoBoard : Mod, IGlobalSettings<GlobalSettings>, ILocalSettings<SaveSettings>
    {
        internal static BingoBoard Instance;

        #region Settings
        public static SaveSettings localSettings { get; set; } = new SaveSettings();
        public void OnLoadLocal(SaveSettings s) => localSettings = s;
        public SaveSettings OnSaveLocal() => localSettings;

        public static GlobalSettings globalSettings { get; set; } = new GlobalSettings();
        public void OnLoadGlobal(GlobalSettings s) => globalSettings = s;
        public GlobalSettings OnSaveGlobal() => globalSettings;
        #endregion

        public override void Initialize()
        {
            Instance = this;

            SpriteLoader.LoadSprites();

            if (ModHooks.GetMod(nameof(ItemChanger.ItemChangerMod)) is Mod)
            {
                Log("Hooking Itemchanger");
                ItemChangerCompatibility.Initialize();
            }
            
            BingoSync.Setup();
            BingoSync.Instance.Initialize();
        }


        public override string GetVersion() => Vasi.VersionUtil.GetVersion<BingoBoard>();
    }
}