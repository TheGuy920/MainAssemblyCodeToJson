using MainAssemblyProg;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Math = MainAssemblyProg.Math;

class Script
{
    // SETUP VAR HERE START
    ProgramableProperties accelerometer_sensor_01 = new ProgramableProperties();
    public void StartUp()
    {
        //accelerometer_sensor_01 = ProgramableProperties.AddProperty(new ObjectProperties
        //{
            
        //}, Programables.NewPart("//full name", "default_name"));

    }
    // SETUP VAR HERE END
    public void ScriptMain()
    {
        var WSControl1 = Controls.CreateInput(Keyboard.KeyInput("W"), Keyboard.KeyInput("S"));
        var thingy = Math.Negate(WSControl1);
        var thing0 = Math.Add(thingy, WSControl1);
        Math.Abs(thing0);
    }
}