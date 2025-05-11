using UnityEngine;
using UnityEngine.UI;
namespace Shop
{
    public class EquiptManager : MonoBehaviour
    {
        public GameObject[] equipSpots;
        [SerializeField] private ShopManager shopManager;
        [SerializeField] private int currentSpot =0;

        [SerializeField] private Canvas equipCanvas;

        [SerializeField] public PlayerMovement playerMovement;



        void Start()
        {
            Errase();
            shopManager = GetComponent<ShopManager>();
        }

        public void Back()
        {
            playerMovement.enabled = true;
            equipCanvas.enabled = false;
        }

        public void FindEquip()
        {
            for(int index =0; index <= shopManager.items.Length-1; index++)
            {
                if(shopManager.items[index].inventario > 0 )
                {
                    Image currentSprite = equipSpots[currentSpot].GetComponent<Image>();
                    currentSprite.sprite = shopManager.items[index].imagen;
                    currentSprite.color = new Color(255, 255, 255, 255);
                    PrepareSpot();
                }
            }
        }

        private void PrepareSpot()
        {
            Button button = equipSpots[currentSpot].GetComponent<Button>();
            button.enabled = true;
            currentSpot++;
        }

        public void Errase()
        {
            currentSpot = 0;
            for (int index = 0; index <= equipSpots.Length - 1; index++)
            {
                Image currentSprite = equipSpots[index].GetComponent<Image>();
                currentSprite.sprite = null;
                currentSprite.color = new Color(255, 255, 255, 0);
            }
        }

    }

}
