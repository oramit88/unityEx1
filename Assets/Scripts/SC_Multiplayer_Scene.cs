using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SC_Multiplayer_Scene : MonoBehaviour {
    int sliderVal;
    string moneyText;

    // Change the money slider from 1000$ to 2000$ (250$ intervals)
    public void ChangeMoneyValue()
    {
        sliderVal = (int)this.GetComponent<Slider>().value;

        switch (sliderVal)
        {
            case 0:
                moneyText = "1000$";
                break;
            case 1:
                moneyText = "1250$";
                break;
            case 2:
                moneyText = "1500$";
                break;
            case 3:
                moneyText = "1750$";
                break;
            case 4:
                moneyText = "2000$";
                break;
        }

        GameObject.Find("Money Val").GetComponent<Text>().text = moneyText;
    }


    // click on back button and switch to the right scene
    public void ClickBackButton()
    {
        SceneManager.LoadScene("menu");
    }


    // click on options button and switch to the options scene
    public void ClickOptions()
    {
        SceneManager.LoadScene("options");
    }


}
