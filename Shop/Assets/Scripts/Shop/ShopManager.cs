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

        [SerializeField] private Button buyButton;
        [SerializeField] private Button sellButton;

        [SerializeField] private CoinManager coinManager;


        void Start()
        {
            coinManager = GetComponent<CoinManager>();
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
            Verify();
        }

        private void Verify()
        {
            if (int.Parse(inventarioText.text) == 0) sellButton.enabled = false;
            else sellButton.enabled = true;
            if (int.Parse(costText.text) > coinManager.currentCoins) buyButton.enabled = false;
            else buyButton.enabled = true;
        }

        public void BuyItem()
        {
            coinManager.SubstractCoins(int.Parse(costText.text));
            for (int index = 0; index < items.Length; index++)
            {
                if (image.sprite == items[index].imagen)
                {
                    items[index].inventario += 1;
                    inventarioText.text = items[index].inventario.ToString();
                }
                continue;
            }
            Verify();
        }

        public void SellItem()
        {
            coinManager.AddCoins(int.Parse(costText.text));
            for (int index = 0; index < items.Length; index++)
            {
                if (image.sprite == items[index].imagen)
                {
                    items[index].inventario -= 1;
                    inventarioText.text = items[index].inventario.ToString();
                }
                continue;
            }
            Verify();
        }

       

    }
}
