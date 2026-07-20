using HarmonyLib;
using Verse;

namespace UnifiedTraits.HarmonyPatches
{
    [StaticConstructorOnStartup]
    public static class HarmonyInit
    {
        public const string HarmonyId = "com.antigravity.unifiedtraits.core";
        private static bool initialized = false;

        static HarmonyInit()
        {
            Init();
        }

        public static void Init()
        {
            if (initialized) return;

            Harmony harmony = new Harmony(HarmonyId);
            harmony.PatchAll();
            initialized = true;
            Log.Message($"[UnifiedTraits] Patches do Harmony ('{HarmonyId}') aplicados com sucesso.");
        }
    }
}
