using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SC_Menu_Links : MonoBehaviour {

	// click on students info button and switch to the right scene
	public void ClickStudentsInfo () {
        SceneManager.LoadScene("students-info");
    }

    // click on options button and switch to the options scene
    public void ClickOptions()
    {
        SceneManager.LoadScene("options");
    }

    // click on the multiplayer button and switch to the multiplayer scene
    public void ClickOnMultiplayer()
    {
        SceneManager.LoadScene("multiplayer");
    }


}
