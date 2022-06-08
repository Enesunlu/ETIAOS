using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour
{
    public int Speed;
    public float rotationSpeed;
    private Vector3 movement;
    private Rigidbody rigidbody;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
        if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("w") || Input.GetKey("s"))
        {
            anim.SetBool("moving", true);

        }
        else
        {
            anim.SetBool("moving", false);
        }
    }
    private void MoveThePlayer()
    {

        // float x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        // float z = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x, 0, z);
        movement.Normalize();
        // rigidbody.AddForce(movement);

        transform.Translate(movement * Speed * Time.deltaTime, Space.World);

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        };
    }
}
