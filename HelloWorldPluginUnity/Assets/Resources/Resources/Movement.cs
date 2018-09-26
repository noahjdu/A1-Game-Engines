
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject sound;

    Animator m_Animator;
    //[SerializeField]
    public float speed = 5.0f;
    //[SerializeField]
    public float jumpPower = 5.0f;
    public bool canJump = false;
    public bool jumping = false;
    public bool Jumpagain = true;
    //public GameObject jumpnoise;
    public GameObject player;
    public float whoa = 180;
    Vector3 scalething = new Vector3(0.0f, -1, 0.0f);
    Vector3 scalething2 = new Vector4(0, 1, 0, 0);
    //public CharacterController controller; 
    public Rigidbody rb;
    public Animator animator;
    public float distanceAway = .5f;
    // Use this for initialization
    void Start()
    {
       // jumpnoise.SetActive(false);
       // controller = GetComponent<CharacterController>();
        m_Animator = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
      //  sound.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {

        canJump = false;

        if (!Physics.Raycast(transform.position, Vector3.down, distanceAway))
        {
            //  Debug.Log("true");

            
        }
        else
        { canJump = true;
        }
        if (rb.velocity.y > jumpPower)
        {
            Debug.Log("holf it right there");
            rb.velocity.y.Equals(0); }
        if (canJump == false)
        {
            //sound.SetActive(false);
        }
        else if (canJump == true  )
        {
            //if ((Input.GetKey("a") == true || Input.GetKey("d") == true || Input.GetKey("w") == true || Input.GetKey("s") == true))
            //{ sound.SetActive(true); }
            //else
            //{ sound.SetActive(false); }
           
        }
    }
    void FixedUpdate()
    {



      //  float walk = Input.GetAxis("Horizontal") * Time.deltaTime;
        float walk = Input.GetAxis("Vertical") * Time.deltaTime;
        //float walk2 = Input.GetAxis("Vertical") * Time.deltaTime;
        float walk2 = -Input.GetAxis("Horizontal") * Time.deltaTime;

        float leftRot = -Input.GetAxis("LeftRot") * Time.deltaTime *60;
        float RightRot = Input.GetAxis("RightRot") * Time.deltaTime *60;





        //OnCollisionEnter2D(player);
        if (Input.GetButton("Jump") && canJump && ( Physics.Raycast(transform.position, Vector3.down, distanceAway) ))
        {
           // jumpnoise.SetActive(true);
            canJump = false;
            if (jumping == true)
            { }
            else
            { rb.AddForce(0, jumpPower,0 ); }
            
            jumping = true;
            StartCoroutine(Example());
            Jumpagain = false;
            //  rb.AddForce(new Vector2(0, -jumpPower * 3 ), ForceMode.Impulse);

          
                
            //  rb.AddForce(new Vector2(0, jumpPower * 0), ForceMode.Impulse);
           

            if (m_Animator) m_Animator.SetBool("grounded", false);
        }
        else

          


        walk = walk * speed;
        walk2 = walk2 * speed;

        transform.Translate(walk, 0, walk2);
        transform.Rotate(0, leftRot + RightRot, 0);

       
        //if (Mathf.Abs(walk) > 0.0f)
        //{
        //    animator.SetBool("isWalking", true);
        //    //animator.Play("PlayerWalk");
        //}else animator.SetBool("isWalking", false);
        //if (walk < 0.0f)
        //{
        //    this.GetComponent<SpriteRenderer>().flipX = true;
        //}
        //else if (walk > 0f) {
        //    this.GetComponent<SpriteRenderer>().flipX = false;
        //}

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag.Equals("Ground"))
    //    {
    //        canJump = true;
    //        if (m_Animator) m_Animator.SetBool("grounded", true);
    //    }
    //    if (collision.gameObject.tag != ("Ground"))
    //    {
    //        canJump = false;

    //    }
    //    canJump = true;
    //}


    IEnumerator Example()
    {

        yield return new WaitForSeconds(.5f);
        jumping = false;
        //jumpnoise.SetActive(false);

    }



}



