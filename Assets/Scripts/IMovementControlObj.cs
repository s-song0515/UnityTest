using UnityEngine;

public class IMovementControlObj : MonoBehaviour
{
    public float _speed = 5;
    public float _rotAngle = 180;

    Camera _mainCam;
    Vector3 _goalPosition;
    Quaternion _goalRotation;

    void Awake()
    {
        _goalPosition = transform.position;
    }

    void Start()
    {
        //GameObject go = GameObject.Find("Main Camera");
        //_mainCam = go.GetComponent<Camera>();
        _mainCam = Camera.main; // 메인카메라인 경우에만 가능, 임의로 만든 일반 카메라로는 사용할 수 없는 코드
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))         // 0:left, 1:right, 2:center
        if (Input.GetButtonDown("Fire1"))                   // Fire1:left, Fire2:right, Fire3:center
        {
            RaycastHit rHit;
            Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rHit))
            {
                //Debug.Log(rHit.transform.name);
                //Debug.Log(rHit.point);
                //transform.position = rHit.point;
                _goalPosition = rHit.point;
                //Vector3 dir = (_goalPosition - transform.position).normalized;
                //transform.rotation = Quaternion.LookRotation(dir);
                //transform.LookAt(_goalPosition); 
                _goalRotation = Quaternion.LookRotation(_goalPosition - transform.position);
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, _goalPosition, _speed * Time.deltaTime);
        if (_goalRotation.y != 0)
        {                        
        }
        //Vector3 dir = _goalPosition - transform.position;

        //if (dir.magnitude <= 0.1f)
        //    transform.position = _goalPosition;
        //else
        //    transform.position += dir.normalized * _speed * Time.deltaTime;
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("마우스 우클릭 했습니다.");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("마우스 휠클릭 했습니다.");
        }
    }
}
