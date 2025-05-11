using UnityEngine;
using TMPro;
using System.Collections;

namespace Shop
{
    public class CoinManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI uiCoins;
        [SerializeField] private Canvas cantBuy;
        [SerializeField] private int currentCoins;
        [SerializeField] private int startCoins;
        [SerializeField] private float messageTime;
        void Start()
        {
            currentCoins = startCoins;
            UpdateCoins();
        }

        private void OnEnable()
        {
            Jarron.onCollect += AddCoins;
        }

        private void OnDisable()
        {
            Jarron.onCollect -= AddCoins;
        }

        private void UpdateCoins()
        {
            uiCoins.text = currentCoins.ToString();
        }

        private void AddCoins(int mount)
        {
            currentCoins += mount;
            UpdateCoins();
        }

        private void SubstractCoins(int mount)
        {
            if(currentCoins - mount <=0)
            {
                CantBuy();
            }
            else
            {
                currentCoins -= mount;
            }
        }

        private void CantBuy()
        {
            cantBuy.enabled = true;
        }

        IEnumerator WarnigMessage()
        {
            yield return new WaitForSeconds(messageTime);
            cantBuy.enabled = false;
        }
    }
}
