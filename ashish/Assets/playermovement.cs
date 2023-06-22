
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5f;
    public float Jumpforce = 5f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    public bool isOnGround = true;

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

         if(Input.GetKeyDown(KeyCode.Space) && isOnGround){

            playerRb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            isOnGround = false;
         }



        
    }

    private void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.CompareTag("ground")){
            isOnGround = true;
        }
        
    }
}
