using BattleTech;
using BattleTech.UI;
using Harmony;
using InControl;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BattleTech.Data;
using BattleTech.UI.Tooltips;
using HBS;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BTMLAISafetyNet
{
    public class Adapter<T>
    {
        public readonly T instance;
        public readonly Traverse traverse;

        protected Adapter(T instance)
        {
            this.instance = instance;
            traverse = Traverse.Create(instance);
        }
    }
    [HarmonyPatch(typeof(AIUtil), "IsExposedToHostileFire")]
    public static class AIUtil_IsExposedToHostileFire_Patch
    {
        public static bool Prefix(AbstractActor unit, CombatGameState combat, out bool __result)
        {
            if (unit == null || combat == null)
            {
                Logger.LogLine("isexposedtohostilefire: unit or  combat is null");
                __result = false;
                return false;
            }
            __result = false;
            return true;
        }
    }

    [HarmonyPatch(typeof(AIUtil), "IsExposedToHostileFireAndAlone")]
    public static class AIUtil_IsExposedToHostileFireAndAlone_Patch
    {
        public static bool Prefix(AbstractActor unit, CombatGameState combat, out bool __result)
        {
            if (unit == null || combat == null)
            {
                Logger.LogLine("isexposedtohostilefireandalone: unit or  combat is null");
                __result = false;
                return false;
            }
            __result = false;
            return true;
        }
    }

}