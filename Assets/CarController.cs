using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    float speed = 0f;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            speed = 0.2f;
        }

        transform.Translate(speed, 0f, 0f);
        speed *= 0.98f;
    }
}
