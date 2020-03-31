using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour

{
    public float Speed = 10;
    public float LifeTime = 1;
    private float _time;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > LifeTime)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(transform.forward * Speed);
    }
}
