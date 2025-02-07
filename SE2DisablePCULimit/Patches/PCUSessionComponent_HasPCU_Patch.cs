using HarmonyLib;
using Keen.Game2.Simulation.GameSystems.PCU;

namespace SE2DisablePCULimit.Patches
{
    [HarmonyPatch(typeof(PCUSessionComponent), "HasPCU")]
    internal class PCUSessionComponent_HasPCU_Patch
    {
        private static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
