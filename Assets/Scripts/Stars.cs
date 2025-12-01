using Unity.VisualScripting;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public Material starMaterial;
    float timer;
    public float maxIntensity;
    bool goingUp;
    public float changeTimeInSeconds;
    float deltaTimeMultiplier;

    private void Start()
    {
        deltaTimeMultiplier = maxIntensity / changeTimeInSeconds;
        timer = starMaterial.GetFloat(Shader.PropertyToID("_Intensity"));
    }

    void Update()
    {
        if (timer <= 1)
        {
            goingUp = true;
        }
        if (timer > maxIntensity)
        {
            goingUp = false;
        }

        if (goingUp)
        {
            timer += Time.deltaTime * deltaTimeMultiplier;
        }
        else
        {
            timer -= Time.deltaTime * deltaTimeMultiplier;
        }

        starMaterial.SetFloat(Shader.PropertyToID("_Intensity"), timer);
    }
}
