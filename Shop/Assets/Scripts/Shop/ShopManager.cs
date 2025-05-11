using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace Shop
{
    public class ShopManager : MonoBehaviour
    {
        public Item[] items;
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private TextMeshProUGUI costText;
        [SerializeField] private TextMeshProUGUI inventarioText;

        [SerializeField] private Image[] shopSpots;


        void Start()
        {
            SelectData(0);
            FullData(0,8);
        }
        private void OnEnable()
        {
            ShopIndex.onClick += SelectData;
        }

        private void OnDisable()
        {
            ShopIndex.onClick -= SelectData;
        }

        public void FullData(int first, int last)
        {
            for(int pos = first; pos <= last; pos++)
            {
                //if (items[last] == null) FullData(0,8);
                shopSpots[pos].sprite = items[pos].imagen;
            }
        }

        public void SelectData(int index)
        {
            image.sprite = items[index].imagen;
            nameText.text = items[index].nombre;
            costText.text = items[index].costo.ToString();
            inventarioText.text = items[index].inventario.ToString();
        }
    }
}
