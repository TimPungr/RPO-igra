using UnityEngine;
using System.Collections;



public class Level11Script : MonoBehaviour
{
    public int stTegaLv;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {

            PlayerPrefs.SetInt("LevUnlock", stTegaLv);

            Application.LoadLevel(stTegaLv + 1);
        }


    }

    public int StevilkaLevela()
    {
        return stTegaLv;
    }

}




