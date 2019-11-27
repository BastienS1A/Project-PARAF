using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eau : MonoBehaviour
{

    public GameObject Sphere;
    private Vector3 chute=new Vector3(0, -0.0981f, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Sphere.transform.position + chute;
        chute=new Vector3(0, -0.981f*Time.time, 0);
        }
}
