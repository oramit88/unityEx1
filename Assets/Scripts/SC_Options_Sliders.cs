using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SC_Options_Sliders : MonoBehaviour {

    // On start, check the user's previous music and sfx values in PlayerPrefs and get them if they aren't null
    void Start () {
        int musicVal = PlayerPrefs.GetInt("Music_Val");
        int sfxVal = PlayerPrefs.GetInt("Sfx_Val");

        if (musicVal != 0)
        {
            GameObject.Find("music_show_val").GetComponent<Text>().text = musicVal.ToString();
            GameObject.Find("Music Slider").GetComponent<Slider>().value = musicVal;
        }

        if (musicVal != 0)
        {
            GameObject.Find("sfx_show_val").GetComponent<Text>().text = sfxVal.ToString();
            GameObject.Find("Sfx Slider").GetComponent<Slider>().value = sfxVal;
        }
    }
	
    // Change the music slider value and its text
    public void ChangeMusicValue()
    {
        GameObject.Find("music_show_val").GetComponent<Text>().text = ((int)this.GetComponent<Slider>().value).ToString();
        PlayerPrefs.SetInt("Music_Val", (int)this.GetComponent<Slider>().value);
    }

    // Change the sfx slider value and its text
    public void ChangeSfxValue()
    {
        GameObject.Find("sfx_show_val").GetComponent<Text>().text = ((int)this.GetComponent<Slider>().value).ToString();
        PlayerPrefs.SetInt("Sfx_Val", (int)this.GetComponent<Slider>().value);
    }

    // click on back button and switch to the right scene
    public void ClickBackButton()
    {
        SceneManager.LoadScene("menu");  
    }



}
