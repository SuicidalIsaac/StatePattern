using ConsoleRPG.TrafficLights;
using ConsoleRPG.TrafficLights.States;

namespace ConsoleRPG
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