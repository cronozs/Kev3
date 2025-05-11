using UnityEngine;

namespace Shop
{
    public class Mirror : MonoBehaviour, IInteract
    {
        [SerializeField] private Canvas interactCanvas;
        [SerializeField] private Canvas equipCanvas;

        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private EquiptManager equiptManager;
        private bool _canInteract = false;
        public void Interact()
        {
            equipCanvas.enabled = true;
            playerMovement.enabled = false;
            equiptManager.Errase();
            equiptManager.FindEquip();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _canInteract) Interact();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            interactCanvas.enabled = true;
            _canInteract = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            interactCanvas.enabled = false;
            _canInteract = false;
        }
    }
}
