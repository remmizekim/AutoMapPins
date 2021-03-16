using HarmonyLib;
using System.Collections.Generic;

namespace AutoMapPins.src
{
    [HarmonyPatch]
    public static class PickablePicked
    {
        private static List<string> PickablesToTrack = new List<string>()
        {
            "$item_thistle",
            "$item_raspberries",
            "$item_blueberries"
        };

        [HarmonyPatch(typeof(Pickable), "Interact")]
        [HarmonyPostfix]
        private static void PickableOnPicked(ref Pickable __instance)
        {
            var name = __instance.m_itemPrefab.GetComponent<ItemDrop>().m_itemData.m_shared.m_name;
            ZLog.Log("Pickable awake with name " + name);
            if (PickablesToTrack.Contains(name))
                PinHelper.AddSinglePin(__instance.transform.position, Minimap.PinType.Icon3, name);
        }
    }
}