using UnityEngine;

public class CylinderOrbit : MonoBehaviour
{
    public float speed = 10f; // Speed of rotation
    public float xRadius = 5f; // Radius of the ellipse on the x-axis
    public float zRadius = 10f; // Radius of the ellipse on the z-axis
    public AudioClip audioClip; // The audio clip to play
    private float time;
    private AudioSource audioSource; // The audio source component

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;

        float x = Mathf.Cos(time) * xRadius;
        float z = Mathf.Sin(time) * zRadius;

        transform.position = new Vector3(x, transform.position.y, z);
    }
}