using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    [SerializeField] private float divisor = 500f;
    
    float speed = 0f;
    Vector2 startPos;

    InputAction swipeAction;
    InputAction swipePointAction;
    AudioSource audioSource;

    void Start()
    {
        Application.targetFrameRate = 60;

        swipeAction = InputSystem.actions.FindAction("Car/Swipe");
        swipePointAction = InputSystem.actions.FindAction("Car/SwipePoint");

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (swipeAction.WasPressedThisFrame())
        {
            startPos = swipePointAction.ReadValue<Vector2>();
        }
        else if (swipeAction.WasReleasedThisFrame())
        {
            Vector2 endPos = swipePointAction.ReadValue<Vector2>();
            float swipeLength = endPos.x - startPos.x;

            speed = swipeLength / divisor;
            
            audioSource.Play();
        }

        transform.Translate(speed, 0f, 0f);
        speed *= 0.98f;
    }
}
