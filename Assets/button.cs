using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void Change_button()
    {
        ballmove.stage = 1;
        SceneManager.LoadScene("game");
    }
}