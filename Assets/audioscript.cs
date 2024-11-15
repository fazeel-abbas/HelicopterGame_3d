using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioscript : MonoBehaviour
{
    public GameObject mutebutton;
    public GameObject unmutebutton;
   
    public static bool muteflag;                   // Pass mute unmute on the other screen as well
   
    // Start is called before the first frame update
    void Start()
    {
       
        if (muteflag == true)
        {
            AudioListener.volume = 0;                // Audiolistner zero means all the audio source off
            mutebutton.SetActive(false);             // AudioListner is connected to Main Camera
        }

        if (muteflag == false)
        {
            AudioListener.volume = 1;
            unmutebutton.SetActive(false);
        }
        
    }
    public void mutegame()
    {
      
        AudioListener.volume = 0;
        mutebutton.SetActive(false);
        unmutebutton.SetActive(true);
        muteflag = true;
    }
    public void unmutegame()
    {
        if (muteflag == true)
        {
           
            AudioListener.volume = 1;      // Audiolistner zero means all the audio source on
            mutebutton.SetActive(true);
            unmutebutton.SetActive(false);
            muteflag = false;
        }
    }

    public void playlevel1()
    {
        SceneManager.LoadScene("HeliScene");
    }

    public void loadmainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
