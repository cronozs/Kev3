using UnityEngine;

namespace Shop
{
    public class StartGame : MonoBehaviour
    {
        [SerializeField] private Canvas beginCanvas;
        [SerializeField] private Canvas mainCanvas;
        [SerializeField] private PlayerMovement playerMovement;

       public void StartTheGame()
        {
            beginCanvas.enabled = false;
            mainCanvas.enabled = true;
            playerMovement.enabled = true;
        }
    }
}
