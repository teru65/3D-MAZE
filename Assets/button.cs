using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    public void change_button() //change_buttonという名前にします
    {
        SceneManager.LoadScene("game");
    }
}
