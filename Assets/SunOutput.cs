// SunOutput.cs
using UnityEngine;

public class SunOutput : MonoBehaviour
{
    public float minSunlightIntensity = 500f; // Minimum sunlight intensity in watts per square meter
    public float maxSunlightIntensity = 1000f; // Maximum sunlight intensity in watts per square meter

    public float GetSunlightIntensity()
    {
        // Generate a random sunlight intensity between minSunlightIntensity and maxSunlightIntensity
        float sunlightIntensity = Random.Range(minSunlightIntensity, maxSunlightIntensity);

        return sunlightIntensity;
    }
}