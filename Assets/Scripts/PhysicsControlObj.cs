using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsControlObj : MonoBehaviour
{
    public float _force = 10;
    public float _speed = 3;
    public float _rotSpd = 5;
    Rigidbody _rgbd3D;

    void Awake()
    {
        _rgbd3D = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float dirX = 0, dirZ = 0;
        float rotY = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("UpArrow 누르고 있어요~~");
            dirZ += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            dirZ -= 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX += 1;
        }
        if (Input.GetKey(KeyCode.Delete))
        {
            rotY -= 1;
        }
        if (Input.GetKey(KeyCode.PageDown))
        {
            rotY += 1;
        }
        Vector3 vDir = new Vector3(dirX, 0, dirZ);        
        vDir.Normalize();
        if (rotY != 0)
        {            
            Quaternion target = _rgbd3D.rotation * Quaternion.Euler(0, _rotSpd * rotY * Time.deltaTime, 0);
            _rgbd3D.MoveRotation(target/*이번 프레임에서의 도착 방향*/);
        }
        //_rgbd3D.AddForce(vDir * _force);        
        _rgbd3D.MovePosition(_rgbd3D.position + _rgbd3D.rotation * vDir * _speed * Time.deltaTime);
    }
}
