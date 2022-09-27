using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton1 : MonoBehaviour
{
    public Button buttonMaterial;
    void Update()
    {
        Button buttonBuy3 = GetComponent<Button>();

        int materialButton3 = PlayerPrefs.GetInt("Button3");

        if (materialButton3 == 1)
        {
            buttonMaterial.interactable = true;
            buttonMaterial.enabled = true;
            buttonBuy3.interactable = false;
            buttonBuy3.enabled = false;
        }
        else if (materialButton3 == 0)
        {
            buttonMaterial.interactable = false;
            buttonMaterial.enabled = false;
        }

        int activeButton = PlayerPrefs.GetInt("Score");

        if (activeButton >= 20)
        {
            buttonBuy3.interactable = true;
        }
        else
        {
            buttonBuy3.interactable = false;
        }
    }

    public void ActiveMaterial ()
    {
        int i = PlayerPrefs.GetInt("Score");
        i -= 20;
        PlayerPrefs.SetInt("Score", i);
        PlayerPrefs.SetInt("Button3", 1);
    }
}
