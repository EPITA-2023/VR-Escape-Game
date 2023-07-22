using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{   

    float MaxDistance = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private RaycastHit hit;
    private Material m_Mat;
    private Collider obj;


    void Update () 
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            /*Debug.Log("hit point : " + hit.point + ", distance : " + hit.distance + ", name : " + hit.collider.name);
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);*/
            if(hit.transform.gameObject.layer == LayerMask.NameToLayer("Screaming")){
                //obj.GetComponent<CollisionEnter>().OnCollisionEnter(obj);
                hit.transform.gameObject.GetComponent<CollisionEnter>().AudioStart();
            }


        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 1000f, Color.red);
        }
    }
}
