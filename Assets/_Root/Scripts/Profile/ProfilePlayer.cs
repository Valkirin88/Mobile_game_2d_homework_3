using Tool;
using Game.Car;
using Features.Inventory;

namespace Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> CurrentState;
        public readonly CarModel CurrentCar;
        public readonly InventoryModel Inventory;


        public ProfilePlayer(float speedCar, float jumpHeight, float magnetForce, GameState initialState) : this(speedCar, jumpHeight, magnetForce)
        {
            CurrentState.Value = initialState;
        }

        public ProfilePlayer(float speedCar, float jumpHeight, float magnetForce)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new CarModel(speedCar, jumpHeight, magnetForce);
            Inventory = new InventoryModel();
        }
    }
}
