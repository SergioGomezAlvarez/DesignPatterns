using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(livingRoomLight);
            Stereo stereo = new Stereo();

            // Commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);

            GarageDoorUpCommand garageUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, garageUp, garageDown);
            remoteControl.SetCommand(4, stereoOn, stereoOff);

            Console.WriteLine(remoteControl);

            Console.WriteLine("=== Test: Living Room Light On -> Off -> Undo ===");
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n=== Test: Multiple commands to build undo history ===");
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(3);

            Console.WriteLine("\n-- Undo last 4 actions --");
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n-- Extra undo (nothing to undo) --");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n=== Test: Ceiling fan state restore via Undo ===");
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n=== Test: Invalid slot calls (should be ignored) ===");
            remoteControl.OnButtonWasPushed(99);
            remoteControl.OffButtonWasPushed(-1);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\nAll tests executed. Inspect console output to verify correct behavior.");
        }
    }
}