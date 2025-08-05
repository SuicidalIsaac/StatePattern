using StatePattern.TrafficLights;
using StatePattern.TrafficLights.States;

namespace StatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var trafficLight = new TrafficLight();
            trafficLight.Action(TrafficLightActions.Actions.Switch);
            trafficLight.Action(TrafficLightActions.Actions.Switch);
            trafficLight.Action(TrafficLightActions.Actions.Switch);
            trafficLight.Action(TrafficLightActions.Actions.Emergency);
            trafficLight.Action(TrafficLightActions.Actions.Fix);
            trafficLight.Action(TrafficLightActions.Actions.Switch);
            trafficLight.Action(TrafficLightActions.Actions.Switch);

        }
    }
}