using UnityEngine;
using UnityEngine.UI;

public class ComputerNumbers : MonoBehaviour
{

    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    float varA;
    float varB;

    // Start is called before the first frame update
    void Start()
    {
        SetResult();
    }

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult " + (a - b));
        float resultAB = a - b;
        result.text = resultAB.ToString();
    }
}
