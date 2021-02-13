using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Infrastructure
{
  public class Game
  {
    public static IInputService InputService;

    public Game()
    {
      RegisterInputService();
      Debug.Log(InputService);
    }

    private static void RegisterInputService()
    {
      if (Application.isEditor)
        InputService = new StandeloneInputService();
      else
        InputService = new MobileInputService();
    }
  }
}