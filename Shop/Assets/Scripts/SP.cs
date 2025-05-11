using UnityEngine;
using TMPro;
namespace Shop
{
    public class SP : MonoBehaviour
    {
        [SerializeField, TextArea] private string text;
        [SerializeField] private Canvas interactCanvas;
        [SerializeField] private int layerTarget;
        [SerializeField] private TextMeshProUGUI showText;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer != layerTarget) return;
            interactCanvas.enabled = true;
            showText.text = text;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            interactCanvas.enabled = false;
        }
    }
}
