using UnityEngine;
namespace Shop
{
    [CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
    public class Item : ScriptableObject
    {

        public Sprite imagen;
        public string nombre;
        public int costo;
        public int inventario;
        public referencePart type;
        public enum referencePart
        {
            body,
            head
        }
    }
}
