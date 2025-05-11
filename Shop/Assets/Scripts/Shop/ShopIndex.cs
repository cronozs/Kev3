using System;
using UnityEngine;

namespace Shop
{
    public class ShopIndex : MonoBehaviour
    {
        public int index;

        public static Action<int> onClick;


        public void SelectItem()
        {
            onClick.Invoke(index);
        }
    }
}
