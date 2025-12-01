using UnityEngine;

public class MaterialReset : MonoBehaviour
{
    public float material0_startingFloat;
    public float material1_startingFloat;
    public float material2_startingFloat;

    public Material material0;
    public Material material1;
    public Material material2;

    void Awake()
    {
        material0.SetFloat(Shader.PropertyToID("_Intensity"),material0_startingFloat);
        material1.SetFloat(Shader.PropertyToID("_Intensity"), material1_startingFloat);
        material2.SetFloat(Shader.PropertyToID("_Intensity"), material2_startingFloat);
    }
}
