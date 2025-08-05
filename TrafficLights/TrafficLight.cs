using StatePattern.TrafficLights.States;
using StatePattern.TrafficLights.States.ConcreteState;

namespace StatePattern.TrafficLights
{
    internal class TrafficLight
    {
        private ITrafficLightState _state = new GreenState();
        public string State => _state.GetType().Name;
        public void Action(TrafficLightActions.Actions action)
        {
            _state.Action(action, this);
        }
        internal void ChangeState(ITrafficLightState newState)
        {
            _state = newState;
        }
    }
}
