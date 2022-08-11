namespace Features.Shed.Upgrade
{
    internal interface IUpgradable
    {
        float Speed { get; set; }
        float JumpHeight { get; set; }
        float MagnetForce { get; set; }
        void Restore();
    }
}
