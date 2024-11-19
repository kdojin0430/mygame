using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointUi : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;

    [SerializeField]
    private TextMeshProUGUI textScore;

    private void Update()
    {
        textScore.text = gameController.CurrentScore.ToString("F0");
    }
}
