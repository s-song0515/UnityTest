using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMovementControlObj : MonoBehaviour
{
    public float _speed = 3;
    public float _rotAngle = 180;
    
    void Update()
    {        
        float mz = Input.GetAxis("Vertical");       // -1 ~ 1
        //float mz = Input.GetAxisRaw("Vertical");      // -1, 0, 1                   
        float mx = Input.GetAxis("Horizontal");
        float ry = Input.GetAxis("RotLR");

        Vector3 vDir = new Vector3(mx, 0, mz);
        vDir = (vDir.magnitude > 1) ? vDir.normalized : vDir;
        //if (ry != 0)
        //    transform.rotation *= Quaternion.Euler(0, _rotAngle * ry * Time.deltaTime, 0);
        //transform.position += transform.rotation * vDir.normalized * _speed * Time.deltaTime;
        //transform.position += Vector3.forward * mz * _speed * Time.deltaTime;        
        transform.Translate(vDir * _speed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotAngle * ry * Time.deltaTime);
        //Debug.Log(mz);
    }
}
