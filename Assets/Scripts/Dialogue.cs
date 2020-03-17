using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {
    public Text textBox;
    private string defaultText = "You are not near any objects to use \"E\" on";
    private string text;

	// Use this for initialization
	void Start () {
        text = defaultText;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && text != defaultText)
            Say(text);
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Say(defaultText);
        }
    }

    private void Say(string sentence)
    {
        textBox.text = sentence;
    }

    private void OnTriggerStay(Collider collision)
    {
        switch (collision.tag)
        {
            case "Campfire":
                text = "An endless fire that lights up this whole place.";
                break;
            case "Igloo":
                text = "The penguin's mightiest home. No one can have it.";
                break;
            case "RadioTower":
                text = "Bzzt! This radiotower seems to still be active.";
                break;
            case "Toad":
                text = "Toad: Get away from my source of communication!";
                break;
            case "Tent":
                text = "This tent was used recently, but by whom?";
                break;
            case "Stump":
                text = "A stump with an axe embedded on the top.";
                break;
            case "Tree":
                text = "A tree that was not able to survive here unlike you.";
                break;
            case "Rock": //Not Implemented Yet, no sphere colliders on rocks
                break;
            case "Sign":
                text = "Sadly, a penguin can not read what this sign says.";
                break;
            case "Snowman":
                text = "You are glad to see these decorated snowmen here.";
                break;
            case "Hut":
                text = "A cozy hut. Maybe I should live here instead.";
                GameObject.Find("HutNew").GetComponent<Animator>().SetTrigger("Open");
                break;
            default:
                text = defaultText;
                break;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        text = defaultText;
        Debug.Log(collision.tag);
        if (collision.tag == "Hut")
            GameObject.Find("HutNew").GetComponent<Animator>().SetTrigger("Close");
    }

}
