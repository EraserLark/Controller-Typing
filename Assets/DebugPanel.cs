using UnityEngine;
using UnityEngine.UI;

public class DebugPanel : MonoBehaviour
{
    Text inputDir;
    Text inputMag;
    Text roundInput;
    Text qDir;

    private void Awake()
    {
        inputDir = transform.GetChild(1).GetComponent<Text>();
        inputMag = transform.GetChild(2).GetComponent<Text>();
        roundInput = transform.GetChild(3).GetComponent<Text>();
        qDir = transform.GetChild(4).GetComponent<Text>();
    }

    public void UpdateInputDir(Vector2 direction)
    {
        inputDir.text = "Input Direction: " + direction;
    }

    public void UpdateVectorMag(float vecMag)
    {
        inputMag.text = "Input Magnitude: " + vecMag;
    }

    public void UpdateRoundedInput(Vector2 roundedInput)
    {
        roundInput.text = "Rounded Input: " + roundedInput;
    }

    public void UpdateQuantizedInput(Vector2 qInput)
    {
        qDir.text = "Quantized Direction: " + qInput;
    }
}
