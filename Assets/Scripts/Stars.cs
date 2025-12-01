using UnityEngine;

public class Stars : MonoBehaviour
{
    public Material starMaterial;
    float timer;
    public float maxIntensity;
    bool goingUp;
    public float lowestToHighestTime;
    float deltaTimeMultiplier;

    private void Start()
    {
        starMaterial.SetFloat(Shader.PropertyToID("_Intensity"), 1);
        deltaTimeMultiplier = maxIntensity / lowestToHighestTime;
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
