using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_PlayerMovement : MonoBehaviour {
	[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;	// How much to smooth out the movement

    Rigidbody2D body;

    public float runSpeed = 40f;
    float horizontal = 0f;
    float vertical = 0f;
	private Vector3 m_Velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        if (horizontal != 0 && vertical != 0) {
            horizontal *= 0.7f;
            vertical *= 0.7f;
        }

        // body.velocity = new Vector2(
        //     horizontal * runSpeed * Time.fixedDeltaTime,
        //     vertical * runSpeed * Time.fixedDeltaTime);

        // // Move the character by finding the target velocity
        // Vector3 targetVelocity = new Vector2(move * 10f, body.velocity.y);
        Vector3 targetVelocity = new Vector2(
            horizontal * runSpeed * Time.fixedDeltaTime,
            vertical * runSpeed * Time.fixedDeltaTime);
        // // And then smoothing it out and applying it to the character
        body.velocity = Vector3.SmoothDamp(
            body.velocity,
            targetVelocity,
            ref m_Velocity,
            m_MovementSmoothing);
    }
}
