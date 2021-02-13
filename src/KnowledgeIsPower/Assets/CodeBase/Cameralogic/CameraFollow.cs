using CodeBase.Hero;
using UnityEngine;

namespace CodeBase.Cameralogic
{
  public class CameraFollow : MonoBehaviour
  {
    [SerializeField] private float RotationAngleX;
    [SerializeField] private float Distance;
    [SerializeField] private float _offsetY;

    private Transform _target;

    private void Start()
    {
      _target = FindObjectOfType<HeroMove>().transform;
    }

    private void LateUpdate()
    {
      Quaternion rotation = Quaternion.Euler(RotationAngleX, 0, 0);
      transform.rotation = rotation;
      
      Vector3 position = rotation * new Vector3(0, 0, -Distance) + TrackTarget();
      transform.position = position;
    }
    
    private Vector3 TrackTarget()
    {
      Vector3 fllowingPosition = _target.position;
      fllowingPosition.y += _offsetY;

      return fllowingPosition;
    }
  }
}