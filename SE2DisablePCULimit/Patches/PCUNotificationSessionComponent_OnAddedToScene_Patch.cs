using HarmonyLib;
using Keen.Game2.Client.GameSystems.PCU;

namespace SE2DisablePCULimit.Patches
{
    [HarmonyPatch(typeof(PCUNotificationSessionComponent), "Keen.VRage.Core.Game.Systems.IInSceneListener.OnAddedToScene")]
    internal class PCUNotificationSessionComponent_OnAddedToScene_Patch
    {
        private static bool Prefix()
        {
            return false;
        }
    }
}
