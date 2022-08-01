using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public TextMeshProUGUI counterGUI;
    private int counter = 0;
    public Light lighting;

    public TextMeshProUGUI buttonGUI;
    public AudioSource buttonSFX;

    public string nextLevelName;

    public Light Lighting { get => lighting; set => lighting = value; }

    // Start is called before the first frame update
    void Start()
    {   //Update the counterGUI text to display current count
        counterGUI.SetText("Counter: " + counter);
        //Update the buttonGUI to say "Turn Off"
        buttonGUI.SetText("Turn Off");
    }


    public void TurnLightOnOff()
    {
        if (lighting.enabled)
        {
            lighting.enabled = false;
            //Update the buttonGUI to say "Turn On" 
            buttonGUI.SetText("Turn On");
        }
        else
        {
            lighting.enabled = true;
            counter++;
            lighting.color = new Color(Random.Range(0, 0.99f), Random.Range(0, 0.99f), Random.Range(0, 0.99f), 1);
            //Update the counterGUI text to display current count
            counterGUI.SetText("Counter: " + counter);
            //Update the buttonGUI to say "Turn Off"
            buttonGUI.SetText("Turn Off");
        }
        buttonSFX.Play();
    }

    public void GoToNextLevel()
    {
        //Use Scene Manager and the nextLevelName variable to Load into MainMenu
        SceneManager.LoadScene(nextLevelName);
        //Use the buttonSFX to play when this function executes
        buttonSFX.Play();
    }
}