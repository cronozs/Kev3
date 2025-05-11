using System;
using UnityEngine;

namespace Shop
{
    public class Jarron : MonoBehaviour, IInteract
    {
        [SerializeField] private Canvas interactCanvas;
        private bool _canInteract = false;

        public static Action<int> onCollect;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _canInteract) Interact();
        }

        public void Interact()
        {
            onCollect.Invoke(1);
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
