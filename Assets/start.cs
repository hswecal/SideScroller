using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); // F�r att starta spelet Byt ut text inom "" mot spel scenen - Casper
        print("Funkar");
    }
}
