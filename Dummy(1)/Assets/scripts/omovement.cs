using UnityEngine;

public class omovement : MonoBehaviour
{
    // Update is called once per frame

    public Rigidbody rb;
    public float force = 200f;

    void Update()
    {
        if(Input.GetKey("a")){
            rb.velocity = new Vector3(0,-2,-4);
        }
        if(Input.GetKey("d")){
            rb.AddForce(0,0,force*Time.deltaTime);
        }
        if(Input.GetKey("w")){
            rb.AddForce(-force*Time.deltaTime,0,0);
        }
        if(Input.GetKey("s")){
            rb.AddForce(force*Time.deltaTime,0,0);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector3(0,8,0);
        }
    }
}
