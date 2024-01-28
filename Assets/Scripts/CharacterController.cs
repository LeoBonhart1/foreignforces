using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float fastSpeed = 10f;

    private bool isFastWalking;
    private Rigidbody rb;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (GameManager.Instance.isGameOver) return;

        Movement();
    }

    private void Movement()
    {
        isFastWalking = Input.GetKey(KeyCode.LeftShift);
        var currentSpeed = isFastWalking ? fastSpeed : normalSpeed;
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (movement == Vector3.zero)
        {
            animator.SetBool("Walk", false);
            return;
        }

        animator.SetBool("Walk", true);

        // Use Rigidbody for physics-based movement
        var velocity = movement * currentSpeed;
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}