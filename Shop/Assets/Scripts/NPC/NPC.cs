using UnityEngine;
using TMPro;

namespace Shop
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
    public class NPC : MonoBehaviour, IInteract
    {
        [SerializeField, TextArea] private string npcText;
        [SerializeField] private Canvas npcCanvas;
        [SerializeField] private Canvas interactCanvas;
        [SerializeField] private TextMeshProUGUI showText;

        [SerializeField] private bool _canInteract = false;

        private void Update()
        {
            Interact();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            interactCanvas.enabled = true;
            showText.text = npcText;
            _canInteract = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            _canInteract = false;
            npcCanvas.enabled = false;
            interactCanvas.enabled = false;
        }

        public void Interact()
        {
            if (_canInteract && Input.GetKeyDown(KeyCode.E))
            {
                interactCanvas.enabled = false;
                npcCanvas.enabled = true;
            }
        }
    }
}
