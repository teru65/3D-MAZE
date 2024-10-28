using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    public void OnButtonPressed() // ボタンが押されたときに呼び出されるメソッド
    {
        ballmove.stage = 1;
        SceneManager.LoadScene("game");
    }
}
