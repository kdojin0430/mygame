using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private readonly float scorScale = 100; // 점수 증가 계수 (읽기 전용)

    // 플레이어 점수 (죽지않고 버틴 시간)
    public float CurrentScore { private set; get; } = 0;

    private void Update()
    {
        CurrentScore += Time.deltaTime * scorScale;
    }
}
