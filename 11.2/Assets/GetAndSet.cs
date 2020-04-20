using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAndSet : MonoBehaviour
{
    

    string m_PlayerName;

    void Start()
    {
        m_PlayerName = "Enter Your Name";
        SetText();
    }

    void Update()
    {
        //Give the PlayerPrefs some values to send over to the next Scene
        PlayerPrefs.SetString("Name", m_PlayerName);
    }
    void SetText()
    {
        //Fetch name (string) from the PlayerPrefs (set these Playerprefs in another script). If no string exists, the default is "No Name"
        m_PlayerName = PlayerPrefs.GetString("Name", "No Name");
    }


    void OnGUI()
    {
        
        GUI.Label(new Rect(350, 150, 200, 30), "Name : " + m_PlayerName);
        //Create a Text Field where the user inputs their name
        m_PlayerName = GUI.TextField(new Rect(350, 200, 200, 20), m_PlayerName, 25);

      
    }
}
