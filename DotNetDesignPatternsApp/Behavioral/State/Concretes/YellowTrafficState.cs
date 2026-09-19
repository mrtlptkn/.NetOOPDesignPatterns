using DotNetDesignPatternsApp.Behavioral.State.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.State.Concretes;

public class YellowTrafficState : ITrafficLightState
{
    public void Next(TrafficLight trafficLight)
    {
        trafficLight.SetState(new GreenTraficState());
        Console.WriteLine("[Sarı] -> Yeşile geçiliyor");
    }

    public string Color => "Yellow";

    public string Description => "Hazırda Bekle!";

    // Sarıdayken sadece kırmızı ve yeşile geçebiliriz.
    public bool CanTransitionTo(ITrafficLightState targetState)
    {
        string targetColor = targetState.Color;
        return "Red" == targetColor || "Green" == targetColor;
    }
}
