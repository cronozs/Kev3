using UnityEngine;
using TMPro;
using System.Collections;

namespace Shop
{
    public class CoinManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI uiCoins;
        [SerializeField] private Canvas cantBuy;
        [SerializeField] private int startCoins;
        [SerializeField] private float messageTime;

        public int currentCoins;
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

        public void AddCoins(int mount)
        {
            currentCoins += mount;
            UpdateCoins();
        }

        public void SubstractCoins(int mount)
        {
            currentCoins -= mount;
            UpdateCoins();
        }

       
    }
}
