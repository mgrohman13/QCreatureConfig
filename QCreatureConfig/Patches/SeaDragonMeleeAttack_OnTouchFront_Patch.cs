﻿using Harmony;

namespace QCreatureConfig.Patches
{
    [HarmonyPatch(typeof(SeaDragonMeleeAttack))]
    [HarmonyPatch("OnTouchFront")]
    class SeaDragonMeleeAttack_OnTouchFront_Patch
    {
        public static void Prefix(SeaDragonMeleeAttack __instance)
        {
            QCreatures.lastTouched = __instance.seaDragon;
        }

        public static void Postfix()
        {
            QCreatures.lastTouched = null;
        }
    }
}