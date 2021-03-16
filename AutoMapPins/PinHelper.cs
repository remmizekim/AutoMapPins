using System.Reflection;
using UnityEngine;

namespace AutoMapPins
{
    public static class PinHelper
    {
        public static void AddSinglePin(Vector3 position, Minimap.PinType pinType, string name)
        {
            // Check for exisiting pin
            MethodInfo dynMethod = Minimap.instance.GetType().GetMethod("HaveSimilarPin", BindingFlags.NonPublic | BindingFlags.Instance);
            bool haveSimiliarPin = (bool)dynMethod.Invoke(Minimap.instance, new object[] { position, pinType, name, true });

            if (!haveSimiliarPin)
                Minimap.instance.AddPin(position, pinType, name, true, false);
        }
    }
}