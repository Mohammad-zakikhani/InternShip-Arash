using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    private Rigidbody rb;
    public Vector3 jump;
    public float jumpForce = 4.0f;
    public bool isGrounded;

    public GameObject playerObj;
    Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        animator = playerObj.GetComponent<Animator>();
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * rb.mass);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if(isGrounded == false)
        {
            animator.enabled = false;
        }
    }
}
