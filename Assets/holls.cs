using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Jobs;


public class holls : MonoBehaviour
{

    public GameObject prefab;
    private GameObject prefabInstance; // プレハブのインスタンスを保持
                                       //インスタンス＝プレハブから生成された具体的なオブジェクト。
    public void ReceiveMessage()
    {
        if (prefabInstance != null)
        {
            Destroy(prefabInstance);
        }

        // goalcount が 1 のときにプレハブを生成
        if (ball.goalcount == 1)
        {
            if (prefab != null)
            {
                // ワールド座標を指定
                Vector3 worldPosition = new Vector3(0.05f, 0.5f, 0.37f); // 任意の座標を指定
                // プレハブをインスタンス化する
                prefabInstance = Instantiate(prefab, worldPosition, Quaternion.identity);
                // 親オブジェクト「maze」を設定する
                Transform parentTransform = GameObject.Find("maze")?.transform;
                if (parentTransform != null)
                {
                    prefabInstance.transform.SetParent(parentTransform, false); // ワールド座標を維持
                }
                // インスタンスの大きさを設定
                prefabInstance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }
        else if (ball.goalcount == 2)
        {
            if (prefab != null)
            {
                // ワールド座標を指定
                Vector3 worldPosition = new Vector3(0.05f, 0.5f, 0.37f); // 任意の座標を指定
                // プレハブをインスタンス化する
                prefabInstance = Instantiate(prefab, worldPosition, Quaternion.identity);
                // 親オブジェクト「maze」を設定する
                Transform parentTransform = GameObject.Find("maze")?.transform;
                if (parentTransform != null)
                {
                    prefabInstance.transform.SetParent(parentTransform, false); // ワールド座標を維持
                }
                // インスタンスの大きさを設定
                prefabInstance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);


                // ワールド座標を指定
                Vector3 worldPosition1 = new Vector3(-0.2f, 0.5f, -0.17f); // 任意の座標を指定
                // プレハブをインスタンス化する
                prefabInstance = Instantiate(prefab, worldPosition1, Quaternion.identity);
                // 親オブジェクト「maze」を設定する
                Transform parentTransform1 = GameObject.Find("maze")?.transform;
                if (parentTransform1 != null)
                {
                    prefabInstance.transform.SetParent(parentTransform1, false); // ワールド座標を維持
                }
                // インスタンスの大きさを設定
                prefabInstance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }






    }
}