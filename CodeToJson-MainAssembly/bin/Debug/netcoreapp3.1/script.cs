using MainAssemblyProg;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Math = MainAssemblyProg.Math;

class Script
{
    // SETUP VAR HERE START
    ProgramableProperties trailmaker_02_0000 = new ProgramableProperties();
    ProgramableProperties segmentdisplay_01a_0000 = new ProgramableProperties();
    ProgramableProperties light_indicator_02_0000 = new ProgramableProperties();
    ProgramableProperties light_indicator_01_0000 = new ProgramableProperties();
    ProgramableProperties led_tricolor_01_0000 = new ProgramableProperties();
    ProgramableProperties tail_light_02_0000 = new ProgramableProperties();
    ProgramableProperties tail_light_03_0000 = new ProgramableProperties();
    ProgramableProperties head_light_03_0000 = new ProgramableProperties();
    ProgramableProperties led_bar_small_01_0000 = new ProgramableProperties();
    ProgramableProperties tail_light_01_0000 = new ProgramableProperties();
    ProgramableProperties head_light_02_0000 = new ProgramableProperties();
    ProgramableProperties head_light_01_0000 = new ProgramableProperties();
    ProgramableProperties light_auxiliary_01_0000 = new ProgramableProperties();
    ProgramableProperties emergency_beacon_01_0000 = new ProgramableProperties();
    ProgramableProperties audio_emitter_01_0000 = new ProgramableProperties();
    ProgramableProperties periscope_01_0000 = new ProgramableProperties();
    ProgramableProperties camera_01_0000 = new ProgramableProperties();
    ProgramableProperties smart_sensor_01_0000 = new ProgramableProperties();
    ProgramableProperties gyroscope_sensor_01_0000 = new ProgramableProperties();
    ProgramableProperties gps_sensor_01_0000 = new ProgramableProperties();
    ProgramableProperties depth_sensor_01_0000 = new ProgramableProperties();
    ProgramableProperties accelerometer_sensor_01_0000 = new ProgramableProperties();
    ProgramableProperties proximity_sensor_01_0000 = new ProgramableProperties();
    ProgramableProperties suction_pad_01_0000 = new ProgramableProperties();
    ProgramableProperties piston_01_0000 = new ProgramableProperties();
    ProgramableProperties piston_01_small_0000 = new ProgramableProperties();
    ProgramableProperties servo_01_0000 = new ProgramableProperties();
    ProgramableProperties servo_02_0000 = new ProgramableProperties();
    ProgramableProperties hinge_powered_pitch_01_0000 = new ProgramableProperties();
    ProgramableProperties hinge_powered_pitch_02_0000 = new ProgramableProperties();
    ProgramableProperties detachable_01_0000 = new ProgramableProperties();
    ProgramableProperties rcs_thruster_01_0000 = new ProgramableProperties();
    ProgramableProperties jet_engine_01_0000 = new ProgramableProperties();
    ProgramableProperties booster_01_0000 = new ProgramableProperties();
    ProgramableProperties antigravity_steering_01_0000 = new ProgramableProperties();
    ProgramableProperties wheel_hub_02_large_0000 = new ProgramableProperties();
    ProgramableProperties wheel_hub_02_medium_0000 = new ProgramableProperties();
    ProgramableProperties wheel_hub_02_small_0000 = new ProgramableProperties();
    ProgramableProperties wheel_hub_01_large_0000 = new ProgramableProperties();
    ProgramableProperties wheel_hub_01_0000 = new ProgramableProperties();
    ProgramableProperties wheel_hub_00_small_0000 = new ProgramableProperties();
    ProgramableProperties motor_01_large_0000 = new ProgramableProperties();
    ProgramableProperties motor_01_0000 = new ProgramableProperties();
    ProgramableProperties motor_00_small_0000 = new ProgramableProperties();
    // SETUP VAR HERE END
    public void ScriptMain()
    {
        var WSControl1 = Controls.CreateInput(Keyboard.KeyInput("W"), Keyboard.KeyInput("S"));
        var thingy = Math.Negate(WSControl1);
        var thing0 = Math.Add(thingy, WSControl1);
        Math.Abs(thing0);
    }
}