using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private InputManager inputManager;
    private Rigidbody ballRB;
    private bool isBallLaunched;
    void Start()
    {
        // grabbing a reference to RigidBody
        ballRB = GetComponent<Rigidbody>();

        // add a listener to the OnSpacePressed event
        // LaunchBall method will be called on space key press
        inputManager.OnSpacePressed.AddListener(LaunchBall);

        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
        ballRB.isKinematic = true;
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;

        isBallLaunched = true;
        transform.parent = null;
        ballRB.isKinematic = false;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
