using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace TurnThatShitUpM
{
    public class Client : BaseScript
    {
        public Client()
        {
            Tick += OnTick;
        }

        private async Task OnTick()
        {
            var lastVehicle = Game.PlayerPed.LastVehicle;
            
            if (lastVehicle == null) { return; }

            if (lastVehicle.IsEngineRunning)
            {
                SetVehicleRadioLoud(lastVehicle.Handle, true);
            }
            
            await Delay(0);
        }
    }
}