using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPortal(){
        gameObject.SetActive(true);
    }

    private void onCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Player" && player.transform.position.z <= 1){
            //move 2nd floor
            player.transform.position = new  Vector3(1, 6, 3);
        }
        else if(collision.gameObject.name == "Player" && player.transform.position.z <= 7){
            //move 3rd floor
            player.transform.position = new Vector3(1, 12, 3);
        }
    }


}
