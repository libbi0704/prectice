using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI messageText;

    public void ChangeMessage()
    {
        messageText.text = "Goodbye !!!";
    }
}
