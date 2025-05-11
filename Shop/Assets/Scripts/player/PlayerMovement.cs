using UnityEngine;

namespace Shop
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 10;

        void Update()
        {
            if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
                transform.position += Vector3.right * (_speed * Time.deltaTime * Input.GetAxis("Horizontal"));
                transform.position += Vector3.up * (_speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }
        }
    }
}
