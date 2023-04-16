using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private float jumpingPower = 5;

    public Animator animator; 

    Vector3 moveDirection = new Vector3(1, 0, 0);
    Vector2 jumpDirection = new Vector2(0, 1);

    private bool lookingRight = true;

    private Rigidbody2D rigidBody;

    float movement;


    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    bool touchesGround()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    Vector3 initialPlayerPosition;
    int outOfMap = -10;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        initialPlayerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("speed", Mathf.Abs(movement));

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += moveDirection * speed * Time.deltaTime;
            if (!lookingRight)
            {
                transform.Rotate(transform.position.x, 180, 0);
                lookingRight = true;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= moveDirection * speed * Time.deltaTime;
            if (lookingRight)
            {
                transform.Rotate(transform.position.x, 180, 0);
                lookingRight = false;
            }
        }

        

        if (Input.GetKeyDown(KeyCode.UpArrow) && touchesGround())
        {
            rigidBody.velocity = jumpDirection * jumpingPower;
        }

        
        if(transform.position.y < outOfMap)
        {
            transform.position = initialPlayerPosition;
        }


    }


}
