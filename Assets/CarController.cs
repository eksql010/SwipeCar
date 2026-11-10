using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    [SerializeField] private float divisor = 500f;
    
    float speed = 0f;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            startPos = Mouse.current.position.value;
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Vector2 endPos = Mouse.current.position.value;
            float swipeLength = endPos.x - startPos.x;

            speed = swipeLength / divisor;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(speed, 0f, 0f);
        speed *= 0.98f;
    }
}
