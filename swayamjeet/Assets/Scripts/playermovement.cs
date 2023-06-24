
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5f;
    public float Jumpforce = 5f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    public int maxJumpcount  =2;
    public int jumpRemaining = 0;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput  = Input.GetAxis("Vertical");

        //to move the player forward..
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

         // player jump

        if(Input.GetKeyDown(KeyCode.Space) && jumpRemaining > 0){

            playerRb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            jumpRemaining-=1;// reduce number of jump mid air
            
        }

    }

    public void FixedUpdate(){
        if(player.position.y < 0f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isOnGround = true;
            jumpRemaining  = maxJumpcount;//reset no of jumps once we hit the ground.
        }
            
         

    }

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isOnGround = false;
        }
            
         

    }
    

   
}
