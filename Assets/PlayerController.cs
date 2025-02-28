using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    float gravity = 9.81f;
    private CharacterController controller;
    private Vector3 moveDirection;
    private float yVelocity;
   public Rigidbody playerBody;
   public Transform cameraTransform;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (cameraTransform == null && Camera.main != null)
        {
            cameraTransform = Camera.main.transform;
        }
    }


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 camForward = cameraTransform.forward;
        Vector3 camRight = cameraTransform.right;


        camForward.y = 0;
        camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();


        Vector3 move = (camForward * moveZ + camRight * moveX).normalized;
        moveDirection = move * moveSpeed;

        if(controller.isGrounded){
            yVelocity = 0;
            if(Input.GetKeyDown(KeyCode.Space)){
                yVelocity = jumpForce;
            }
        }else{
            yVelocity -= gravity * Time.deltaTime;
        }

        moveDirection.y = yVelocity;
        controller.Move(moveDirection * Time.deltaTime);

    }
}
