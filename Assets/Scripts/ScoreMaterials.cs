using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMaterials : MonoBehaviour
{
    public List<Material> materials = new List<Material>();
    public int score;

    void Update()
    {
        if (score >= 5 && score < 10)
        {
            GetComponent<Renderer>().material = materials[1];
        }
        else if (score >= 10)
        {
            GetComponent<Renderer>().material = materials[2];
        }
        else
        {
            GetComponent<Renderer>().material = materials[0];
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        score++;
    }
}
