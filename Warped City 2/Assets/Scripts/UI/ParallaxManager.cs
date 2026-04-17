using UnityEngine;

public class ParallaxManager : MonoBehaviour
{
    [System.Serializable]
    public class ParallaxLayer
    {
        [Range(0, 1)] public float parallaxFactor;
        public Transform layerTransform;
    }

    public ParallaxLayer[] layers;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Vector3 lastCameraPosition;

    void Start()
    {
        lastCameraPosition = cameraTransform.position;
    }

    void LateUpdate()
    {
        Vector3 delta = cameraTransform.position - lastCameraPosition;

        foreach (ParallaxLayer layer in layers)
        {
            float parallaxX = delta.x * layer.parallaxFactor;
            float parallaxY = delta.y * layer.parallaxFactor;
            layer.layerTransform.position = new Vector3(parallaxX, parallaxY, 0);
        }
        lastCameraPosition = cameraTransform.position;
    }
}
