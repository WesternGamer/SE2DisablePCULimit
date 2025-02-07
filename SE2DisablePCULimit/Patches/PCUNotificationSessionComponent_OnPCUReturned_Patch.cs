using HarmonyLib;
using Keen.Game2.Client.GameSystems.PCU;

namespace SE2DisablePCULimit.Patches
{
    [HarmonyPatch(typeof(PCUNotificationSessionComponent), "OnPCUReturned")]
    internal class PCUNotificationSessionComponent_OnPCUReturned_Patch
    {
        private static bool Prefix()
        {
            return false;
        }
    }
}
