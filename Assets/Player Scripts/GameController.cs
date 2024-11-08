using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private readonly float scorScale = 100; // ���� ���� ��� (�б� ����)

    // �÷��̾� ���� (�����ʰ� ��ƾ �ð�)
    public float CurrentScore { private set; get; } = 0;

    private void Update()
    {
        CurrentScore += Time.deltaTime * scorScale;
    }
}
