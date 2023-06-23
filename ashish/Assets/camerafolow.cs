
using UnityEngine;

public class camerafolow : MonoBehaviour
{
   public Transform target;
   public float smoothSpeed = 0.125f;

   public Vector3 offset;

   void LateUpdate() 
   {
        Vector3 desiredPosition = target.position+ offset;
        Vector3 smoothedPosition = Vector3.Lerp(target.position, desiredPosition, smoothSpeed);//linear interpolation(lerp)

        transform.position = smoothedPosition;

        //transform.Lookat(target);
    
   }
}
