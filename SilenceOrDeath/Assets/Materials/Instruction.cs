using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Instruction : MonoBehaviour
{
    public GameObject light;
    public float time;
    int num;
    public TMP_Text notice;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
    /*
        WriteText("Welcome to the NIGHTMARE game!");
        StartCoroutine ("DelayPanel");
        //Invoke("WriteText", 5);
        WriteText("You find yourself trapped in a mysterious room\nsurrounded by monsters on all sides.\nYour mission is to solve the mystery\nto get the key and escape from this room\nwithout being noticed by the monsters.\nLook around carefully and look for clues.");
        StartCoroutine ("DelayPanel");
        //Invoke("WriteText", 5);
        WriteText("Monsters are very, very sensitive to sound!\nRemember, time is running out!\nYour time to escape is limited.\nKeep an eye on the timer and sound meter.\nDon't panic, stay focused to overcome challenges.");
        StartCoroutine ("DelayPanel");
        //Invoke("WriteText", 5);
        WriteText("Good luck.");
        StartCoroutine ("DelayPanel");
        HidePanel();
        */
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        num = (int)time;
        switch(num){
            case 2:{
                WriteText("Welcome to the Silence or Death game!");
                break;
            }
            case 5:{
                WriteText("You find yourself trapped in a mysterious room\nsurrounded by monsters on all sides.\nYour mission is to solve the mystery\nto get the key and escape from this room\nwithout being noticed by the monsters.\nLook around carefully and look for clues.");
                break;
            }
            case 12:{
                WriteText("Monsters are very, very sensitive to sound!\nRemember, time is running out!\nYour time to escape is limited.\nKeep an eye on the timer and sound meter.\nDon't panic, stay focused to overcome challenges.");
                break;
            }
            case 20:{
                WriteText("Good luck.");
                break;
            }
            case 23:{
                HidePanel();
                break;
            }
        }
    }

    IEnumerator DelayPanel() {
		yield return new WaitForSeconds(0.5f);
	}

    void HidePanel(){
        panel.SetActive(false);
        light.SetActive(false);
    }

    void WriteText(string str){
        notice.text = str;
    }

}
