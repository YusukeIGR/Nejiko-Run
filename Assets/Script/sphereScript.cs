using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //等速運動
        /*
        transform.position=Vector3.MoveTowards(
            transform.position,
            target.position,
            4f*Time.deltaTime//４秒間で移動する。
            );
            */
        //最初早くて後収束
        transform.position=Vector3.MoveTowards(
            transform.position,
            target.position,
            4f*Time.deltaTime//４秒間で移動する。
            );
    }
}
