using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton2 : MonoBehaviour
{
    public Button buttonMaterial;
    void Update()
    {
        Button buttonBuy4 = GetComponent<Button>();

        int materialButton4 = PlayerPrefs.GetInt("Button4");

        if (materialButton4 == 1)
        {
            buttonMaterial.interactable = true;
            buttonMaterial.enabled = true;
            buttonBuy4.interactable = false;
            buttonBuy4.enabled = false;
        }
        else if (materialButton4 == 0)
        {
            buttonMaterial.interactable = false;
            buttonMaterial.enabled = false;
        }

        int activeButton = PlayerPrefs.GetInt("Score");

        if (activeButton >= 5)
        {
            buttonBuy4.interactable = true;
        }
        else
        {
            buttonBuy4.interactable = false;
        }
    }

    public void ActiveMaterial ()
    {
        int i = PlayerPrefs.GetInt("Score");
        i -= 5;
        PlayerPrefs.SetInt("Score", i);
        PlayerPrefs.SetInt("Button4", 1);
    }
}
