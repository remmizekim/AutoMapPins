//using UnityEngine;

//namespace AutoMapPins
//{
//    class PinnedObject: MonoBehaviour
//    {
//        public Minimap.PinData pin;

//        public void Init(string aName)
//        {
//            pin = Minimap.instance.AddPin(transform.position, Minimap.PinType.Icon3, aName, false, false);
//        }

//        void OnDestroy()
//        {
//            if (pin != null && Minimap.instance != null)
//            {
//                Minimap.instance.RemovePin(pin);
//            }
//        }
//    }
//}
