using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SC_Students_Links : MonoBehaviour {

    // click on back button and switch to the right scene
    public void ClickBackButton()
    {
        SceneManager.LoadScene("menu");
    }

    public void OpenLinkToSite()
    {
        Application.OpenURL("http://www.google.com");
    }

    // click on options button and switch to the options scene
    public void ClickOptions()
    {
        SceneManager.LoadScene("options");
    }




}
