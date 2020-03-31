using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Angle;
    public float Speed = 2;
    public float Sensitive = 2;
    public GameObject Missile;
    public float CoolTime = 0.2f;
    private float _coolTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _coolTime += Time.deltaTime;
        if (_coolTime > CoolTime)
        {
            float y = transform.rotation.y;
            y += Input.GetAxis("Horizontal") * Sensitive * Time.deltaTime;
            //transform.rotation = new Quaternion(0, y, 0, 1);
            transform.Rotate(0, y, 0, Space.Self);

            if (Input.GetKey(KeyCode.H))
            {
                GameObject ms = Instantiate(Missile);
                ms.transform.position = this.transform.position;
                ms.transform.rotation = this.transform.rotation;
                
            }
            _coolTime = 0;
        }
    }
}
