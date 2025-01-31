using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 5f;
    [SerializeField] private bool jumpKey = false;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        if (Input.GetKeyDown(KeyCode.Space) && sphereRigidbody.position.y == 0.5)
        {
            jumpKey = true;
        }
        if (jumpKey == true)
        {
            jumpKey = false;
            sphereRigidbody.AddForce(Vector3.up * ballSpeed, ForceMode.VelocityChange);
        }
    }
}
