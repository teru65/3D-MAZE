using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Jobs;

public class Holls : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> prefabInstances = new List<GameObject>(); // プレハブのインスタンスを保持

    public void ReceiveMessage()
    {
        // 既存のインスタンスを削除
        RemoveAllPrefabs();

        // goalcount に応じてプレハブを生成
        if (ball.goalcount == 1)
        {
            CreatePrefab(new Vector3(0.05f, 0.5f, 0.37f), new Vector3(0.5f, 0.5f, 0.5f));
        }
        else if (ball.goalcount == 2)
        {
            CreatePrefab(new Vector3(0.05f, 0.5f, 0.37f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(0.049f, 0.5f, -0.2f), new Vector3(3f, 3f, 3f));
        }
        else if (ball.goalcount == 3)
        {
            CreatePrefab(new Vector3(0.05f, 0.5f, 0.37f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(-0.2f, 0.5f, -0.17f), new Vector3(0.5f, 0.5f, 0.5f));
        }
        else if (ball.goalcount == 4)
        {
            CreatePrefab(new Vector3(0.05f, 0.5f, 0.37f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(-0.2f, 0.5f, -0.17f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(-0.517f, 0.5f, 0.2f), new Vector3(0.5f, 0.5f, 0.5f));
        }
        else if (ball.goalcount == 5)
        {
            CreatePrefab(new Vector3(0.05f, 0.5f, 0.37f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(-0.2f, 0.5f, -0.17f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(-0.517f, 0.5f, 0.2f), new Vector3(0.5f, 0.5f, 0.5f));
            CreatePrefab(new Vector3(0.27f, 0.5f, 0f), new Vector3(1f, 1f, 1f));
            CreatePrefab(new Vector3(0.15f, 0.5f, -0.4f), new Vector3(1f, 1f, 1f));
        }
    }

    private void CreatePrefab(Vector3 position, Vector3 scale)
    {
        // プレハブをインスタンス化する
        GameObject prefabInstance = Instantiate(prefab, position, Quaternion.identity);
        // 親オブジェクト「maze」を設定する
        Transform parentTransform = GameObject.Find("maze")?.transform;
        if (parentTransform != null)
        {
            prefabInstance.transform.SetParent(parentTransform, false); // ワールド座標を維持
        }
        // インスタンスの大きさを設定
        prefabInstance.transform.localScale = scale;

        // インスタンスをリストに追加
        prefabInstances.Add(prefabInstance);
    }

    private void RemoveAllPrefabs()
    {
        foreach (GameObject instance in prefabInstances)
        {
            Destroy(instance);
        }
        prefabInstances.Clear(); // リストをクリア
    }
}
