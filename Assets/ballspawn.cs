using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspawn : MonoBehaviour

{
    public GameObject ballPrefab; // ボールのプレハブ
    public ballmove ball; // 監視するボールオブジェクト

    private bool hasSpawnedStage1 = false; // stage 1用のフラグ
    private bool hasSpawnedStage4 = false; // stage 4用のフラグ

    // 指定した位置にボールを生成するためのフィールド
    public Vector3 spawnPosition; // プレハブを生成する位置

    void Update()
    {
        if (ball != null) // ballがnullでないことを確認
        {
            // stageが1のときにボールを生成
            if (ballmove.stage == 1 && !hasSpawnedStage1)
            {
                SpawnBall(spawnPosition); // 指定した位置で生成
                hasSpawnedStage1 = true;
                ballmove.stage = 0; // ステージをリセット
            }
            // stageが4のときにボールを生成
            else if (ballmove.stage == 4 && !hasSpawnedStage4)
            {
                SpawnBall(spawnPosition); // 指定した位置で生成
                hasSpawnedStage4 = true;
                ballmove.stage = 0; // ステージをリセット
            }
        }
    }

    void SpawnBall(Vector3 position)
    {
        if (ballPrefab != null) // ballPrefabがnullでないことを確認
        {
            Instantiate(ballPrefab, position, Quaternion.identity); // 指定した位置で生成
        }
        else
        {
            Debug.LogError("Ball Prefab is not assigned!");
        }
    }
}
