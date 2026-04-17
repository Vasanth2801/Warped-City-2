using UnityEngine;

public class ParallaxManager : MonoBehaviour
{
    [System.Serializable]
    public class ParallaxLayer
    {
        public Transform layerTransform;
        [Range(0, 1)] public float parallaxFactor;
    }

    public ParallaxLayer[] layers;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Vector3 lastCameraPosition;


}
