using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public GameObject player;
    bool isgrab;
    // Start is called before the first frame update
    void Start()
    {
        isgrab = transform.GetComponent<OVRGrabbable>().isGrabbed;

    }


    private void onCollisionEnter(Collision collision){
        if(player.transform.position.z <= 1){
            //move 2nd floor
            player.transform.position = new  Vector3(1, 6, 3);
        }
        else if(player.transform.position.z <= 7){
            //move 3rd floor
            player.transform.position = new Vector3(1, 12, 3);
        }
    }
    void Update(){
        if(isgrab){
            whenGrab();
        }
    }
    
    void whenGrab(){
        if(player.transform.position.y <= 1){
            //move 2nd floor
            player.transform.position = new  Vector3(1, 6, 3);
        }
        else if(player.transform.position.y <= 7){
            //move 3rd floor
            player.transform.position = new Vector3(1, 12, 3);
        }
        gameObject.SetActive(false);
    }



}
