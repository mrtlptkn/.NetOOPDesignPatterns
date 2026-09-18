namespace DotNetDesignPatternsApp.Behavioral.State;

public class TrafficLightApplication
{
    private readonly TrafficLight _trafficLight;

    public TrafficLightApplication(TrafficLight trafficLight)
    {
        _trafficLight = trafficLight;
    }

    public void Handle(TrafficLightRequest request)
    {
        ITrafficLightState newState = request.Color.ToUpperInvariant() switch
        {
            "RED" => new RedTrafficState(),
            "GREEN" => new GreenTraficState(),
            "YELLOW" => new YellowTrafficState(),
            _ => throw new ArgumentException("Invalid traffic light color: " + request.Color)
        };

        _trafficLight.SetState(newState);
        Console.WriteLine("Current Traffic Light State: " + _trafficLight.State.Color);
    }
}
