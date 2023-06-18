using UnityEngine;

public class movement : MonoBehaviour
{
    // Update is called once per frame
    public Rigidbody rb;
    public float f = 200f;
    void Update()
    {
        if(Input.GetKey("a")){
            rb.AddForce(0,0,-f*Time.deltaTime);
        }
        if(Input.GetKey("d")){
            rb.AddForce(0, 0 ,f*Time.deltaTime);
        }
        if(Input.GetKeyDown("e")){
            rb.AddForce(0,f*Time.deltaTime,0);
        }
    }
}
