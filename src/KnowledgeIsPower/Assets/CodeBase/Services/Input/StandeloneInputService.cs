using UnityEngine;

namespace CodeBase.Services.Input
{
  public class StandeloneInputService : InputService
  {
    public override Vector2 Axis
    {
      get
      {
        Vector2 axis = SimpleInputAxis();

        if (axis == Vector2.zero)
          axis = UnituAxis();

        return axis;
      }
    }

    private static Vector2 UnituAxis() =>
      new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
  }
}