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
        varA = 5;
        varB = 4;
        // Aufruf
        Debug.Log("in Start: " + SubstractNumbers(varA, varB));
        Debug.Log("in Start: " + SubstractNumbers(4, 7));
        Debug.Log(10 - SubstractNumbers(varA, varB));
        Debug.Log(100 - SubstractNumbers(4, 7));
        SetResult();
    }

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult " + (a - b));
        float resultAB = a - b;
        result.text = resultAB.ToString();
        //result.text = SubstractNumbers(a,b);
    }

    public string TestMethod()
    {
        Debug.Log("TEst");
        return "Test";
    }
    public void TestMethodVOID()
    {
        Debug.Log("Test");
    }

    public float MultNumbers(float variableA, float variableB)
    {
        float result = variableA * variableB;
        //Debug.Log("Test sub " + result.ToString());
        return result;
    }

    // Deklaration
    public float SubstractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        //Debug.Log("Test sub " + result.ToString());
        return result;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
