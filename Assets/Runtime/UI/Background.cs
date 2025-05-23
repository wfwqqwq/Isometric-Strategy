using UnityEngine;

public class Background : MonoBehaviour
{
    public float depth = 5f;

    private CameraController cameraController;
    private Camera levelCamera;
    private Vector3 selfPosition;
    private Vector3 cameraPosition;

    private void AfterFixedUpdate()
    {
        transform.position = selfPosition + depth / (depth - 1f) * (levelCamera.transform.position - cameraPosition);
    }

    private void Start()
    {
        levelCamera = GameObject.Find("LevelCamera").GetComponent<Camera>();
        cameraController = levelCamera.GetComponent<CameraController>();
        selfPosition = transform.position;
        cameraPosition = levelCamera.transform.position;
        cameraController.AfterFixedUpdate += AfterFixedUpdate;
    }
}
