using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawn : MonoBehaviour

{
    public GameObject ballPrefab; // ボールのプレハブ

    private bool hasSpawnedStage1 = false; // stage 1用のフラグ
    private bool hasSpawnedStage4 = false; // stage 4用のフラグ
    public Vector3 spawnPosition; // プレハブを生成する位置

    void Update()
    {

        if (ballmove.stage == 1 && !hasSpawnedStage1)
        {
            Debug.Log("a");
            SpawnBall(spawnPosition);
            hasSpawnedStage1 = true;
        }
        else if (ballmove.stage == 4 && !hasSpawnedStage4)
        {
            SpawnBall(spawnPosition);
            hasSpawnedStage4 = true;
        }
    }

    void SpawnBall(Vector3 position)
    {
        if (ballPrefab != null)
        {
            Instantiate(ballPrefab, position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Ball Prefab is not assigned!");
        }
    }
}
