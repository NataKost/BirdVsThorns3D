using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWalGen : MonoBehaviour
{
    public GameObject[] WallsPref;
    public GameObject oldWall;
    private GameObject newWall;
    public Move player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out player))
        {
            int i = PlayerPrefs.GetInt("Score");
            i++;
            PlayerPrefs.SetInt("Score", i);
            Invoke("ChangeWalls", 0.2f);
        }
    }

    public void ChangeWalls ()
    {
        int rnd = Random.Range(0, 6);
        Destroy(oldWall);
        newWall = Instantiate(WallsPref[rnd]);
        oldWall = newWall;
    }
}
