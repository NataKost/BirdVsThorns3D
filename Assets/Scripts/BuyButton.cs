using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public Button buttonMaterial;
    void Update()
    {
        Button buttonBuy2 = GetComponent<Button>();

        int materialButton2 = PlayerPrefs.GetInt("Button2");

        if (materialButton2 == 1)
        {
            buttonMaterial.interactable = true;
            buttonMaterial.enabled = true;
            buttonBuy2.interactable = false;
            buttonBuy2.enabled = false;
        }
        else if (materialButton2 == 0)
        {
            buttonMaterial.interactable = false;
            buttonMaterial.enabled = false;
        }

        int activeButton = PlayerPrefs.GetInt("Score");

        if (activeButton >= 10)
        {
            buttonBuy2.interactable = true;
        }
        else
        {
            buttonBuy2.interactable = false;
        }
    }

    public void ActiveMaterial ()
    {
        int i = PlayerPrefs.GetInt("Score");
        i -= 10;
        PlayerPrefs.SetInt("Score", i);
        PlayerPrefs.SetInt("Button2", 1);
    }
}
