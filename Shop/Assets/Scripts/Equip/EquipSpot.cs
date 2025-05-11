using UnityEngine;
using UnityEngine.UI;
namespace Shop
{
    public class EquipSpot : MonoBehaviour
    {
        [SerializeField] private Image bodyImage;
        [SerializeField] private Image headImage;

        [SerializeField] private EquiptManager equiptManager;
        [SerializeField] private ShopManager shopManager;

        [SerializeField] private int index;
        public void EquipItem()
        {
            Sprite current = equiptManager.equipSpots[index].GetComponent<Image>().sprite;
            for(int count =0; count< shopManager.items.Length; count++)
            {
                if(current == shopManager.items[count].imagen)
                {
                    if(shopManager.items[count].type == Item.referencePart.body)
                    {
                        bodyImage.color = new Color(255, 255, 255, 255);
                        bodyImage.sprite = current;
                    }
                    else
                    {
                        headImage.color = new Color(255, 255, 255, 255);
                        headImage.sprite = current;
                    }
                }
            }
        }
    }
}
