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
    }

    private void Say(string sentence)
    {
        textBox.text = sentence;
    }

    private void OnTriggerEnter(Collider collision)
    {
        switch (collision.tag)
        {
            case "Campfire":
                break;
            case "Igloo":
                break;
            case "RadioTower":
                break;
            case "Toad":
                break;
            case "Tent":
                break;
            case "Stump":
                break;
            case "Tree":
                break;
            case "Rock":
                break;
            case "Sign":
                break;
            case "Snowman":
                break;
            default:
                text = defaultText;
                break;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        text = defaultText;
    }

}
