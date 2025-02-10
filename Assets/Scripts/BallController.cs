using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    private Rigidbody ballRB;
    private bool isBallLaunched;
    void Start()
    {
        // grabbing a reference to RigidBody
        ballRB = GetComponent<Rigidbody>();

        // add a listener to the OnSpacePressed event
        // when the space key is pressed the
        // LaunchBall method will be called
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;

        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
