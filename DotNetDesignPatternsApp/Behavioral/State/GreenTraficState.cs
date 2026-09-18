namespace DotNetDesignPatternsApp.Behavioral.State;

public class GreenTraficState : ITrafficLightState
{
    public void Next(TrafficLight trafficLight)
    {
        trafficLight.SetState(new YellowTrafficState());
        Console.WriteLine("[Yeşil] -> Sarıya geçiliyor");
    }

    public string Color => "Green";

    public string Description => "Hızlan! Geç!";

    // Yeşilden sarıya geçilebilir mi ?
    public bool CanTransitionTo(ITrafficLightState targetState)
    {
        return "Yellow" == targetState.Color;
    }
}
