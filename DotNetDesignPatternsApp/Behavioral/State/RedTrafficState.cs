namespace DotNetDesignPatternsApp.Behavioral.State;

public class RedTrafficState : ITrafficLightState
{
    public void Next(TrafficLight trafficLight)
    {
        trafficLight.SetState(new YellowTrafficState());
        Console.WriteLine("[Kırmızı] -> Sarıya geçiliyor");
    }

    public string Color => "Red";

    public string Description => "Yavaşla! Dur!";

    // Kırmızıdan sarıya geçilebilir mi ?  Evet
    public bool CanTransitionTo(ITrafficLightState targetState)
    {
        return "Yellow" == targetState.Color;
    }
}
