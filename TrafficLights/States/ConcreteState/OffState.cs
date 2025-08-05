namespace StatePattern.TrafficLights.States.ConcreteState
{
    internal class OffState : TrafficLightState
    {
        protected override bool IsActionSupported(TrafficLightActions.Actions action)
        {
            switch (action)
            {
                case TrafficLightActions.Actions.Switch: return true;
                default: return false;
            }
        }
        protected override void ExecuteAction(TrafficLightActions.Actions action, TrafficLight trafficLight)
        {
            trafficLight.ChangeState(new GreenState());
        }
    }
}
