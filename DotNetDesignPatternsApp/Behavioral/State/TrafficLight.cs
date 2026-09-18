namespace DotNetDesignPatternsApp.Behavioral.State;

public class TrafficLight
{
    // Current State -> RED -> Dinamik olarak State nesneleri üzerinden değişim gösterecek.
    public ITrafficLightState State { get; private set; }

    public TrafficLight()
    {
        // initial State
        State = new RedTrafficState();
    }

    // SetState ile farklı bir state'e geçiyoruz.
    public void SetState(ITrafficLightState state)
    {
        // State değişmesi için bir koşulun oluşması gerekiyor diye bir kontrol yaptık.
        if (!State.CanTransitionTo(state))
        {
            Console.WriteLine(State.CannotTransitionMessage(state));
            return;
        }

        State = state;
    }
}
