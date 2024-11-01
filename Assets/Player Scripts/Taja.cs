using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro; 

public class Taja : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    public TMP_InputField m_inputField;

    public void OnEndEdit()
    {
        string inputStr = m_inputField.text;
        string outputStr = inputStr.Replace(" ","");

        m_text.text = outputStr;
    }
   public void OnSelect()
    {
        Debug.Log("OnSelect");
    }
    public void OnDeSelect()
    {
        Debug.Log("OnDeSelect");
    }
}
