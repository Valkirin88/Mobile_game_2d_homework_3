using Features.Shed.Upgrade;

namespace Game.Car
{
    internal class CarModel : IUpgradable
    {
        private readonly float _defaultSpeed;
        private readonly float _defaultJumpHeight;
        private readonly float _defaultMagnetForce;

        public float Speed { get; set; }
        public float JumpHeight { get; set; }
        public float MagnetForce { get; set; }

        public CarModel(float speed, float jumpHeight, float magnetForce )
        {
            _defaultSpeed = speed;
            Speed = speed;

            _defaultJumpHeight = jumpHeight;
            JumpHeight = jumpHeight;

            _defaultMagnetForce = magnetForce;
            MagnetForce = magnetForce;
        }


        public void Restore()
        {
            Speed = _defaultSpeed;
            JumpHeight = _defaultJumpHeight;
            MagnetForce = _defaultMagnetForce;
        }

    }
}
