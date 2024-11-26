// SolarPanel.cs
using System.Collections;
using UnityEngine;

public class SolarPanel : MonoBehaviour
{
    public SunOutput sun; // Reference to the SunOutput object
    public GameObject earth; // Reference to the Earth object
    public float conversionFactor = 0.2f; // Conversion factor from sunlight intensity to solar power

    void Start()
    {
        StartCoroutine(LogSolarPower());
    }

    IEnumerator LogSolarPower()
    {
        while (true)
        {
            Vector3 toSun = sun.transform.position - transform.position;
            float dotProduct = Vector3.Dot(transform.forward, toSun.normalized);

            // Check if the solar panel is in shadow
            bool inShadow = Physics.Raycast(transform.position, toSun, out RaycastHit hit) && hit.transform == earth.transform;

            float sunlightIntensity = inShadow ? 0 : sun.GetSunlightIntensity(); // If in shadow, sunlight intensity is 0
            float adjustedIntensity = sunlightIntensity * Mathf.Max(dotProduct, 0); // Adjust intensity based on angle

            float solarPower = adjustedIntensity * conversionFactor; // Convert sunlight intensity to solar power

            Debug.Log(gameObject.name + " Solar Power: " + solarPower); // Print the solar power to the console

            yield return new WaitForSeconds(2); // Wait for 3 seconds
        }
    }
}