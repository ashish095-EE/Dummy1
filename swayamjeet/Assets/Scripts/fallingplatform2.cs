
using UnityEngine;

public class fallingplatform2 : MonoBehaviour
{
    private Rigidbody rb;
    private bool isfalling  = false;
    private float falldelay = 1f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Player") && !isfalling){
            Invoke("startfalling", falldelay);
            
        }
        
    }

    private void startfalling(){

        rb.isKinematic = false;
        isfalling = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
