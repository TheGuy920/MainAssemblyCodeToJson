using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security;
using MainAssemblyProg;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace MainAssemblyProg
{
    class Math
    {
        public enum Steps
        {
            None,
            Four,
            Eight,
            Sixteen,
            ThirtyTwo
        }
        public enum Boundary
        {
            Ignore,
            Clamp,
            Wrap
        }
        public enum Rounding_Mode
        {
            Floor,
            Round,
            Ceiling,
            Truncate
        }
        public static double  Constant(double Value) { return 0; }
        public static double  Abs(double A = 0) { return 0; }
        public static double  Add(double A = 0, double B = 0) { return 0; }
        public static double  Subtract(double A = 0, double B = 0) { return 0; }
        public static double  Multiply(double A = 0, double B = 0) { return 0; }
        public static double  Divide(double A = 0, double B = 0) { return 0; }
        public static double  Sum(double A = 0, double B = 0, double Duration = 3.0, bool Over_Time = true, Boundary Boundary = Boundary.Clamp, double Lower_Bound = -1.0, double Upper_Bound = 1.0, double Start = 0.0) { return 0; }
        public static double  Power(double A = 0, double B = 0) { return 0; }
        public static double  Derivative(double A = 0) { return 0; }
        public static double  Exponential(double A = 0) { return 0; }
        public static double  Frac(double A = 0) { return 0; }
        public static double  Log(double A = 0) { return 0; }
        public static double  SqaureRoot(double A = 0) { return 0; }
        public static double  Invert(double A = 0, double B = 0) { return 0; }
        public static double  Negate(double A = 0) { return 0; }
        public static double  Split(double A = 0) { return 0; }
        public static double  Quantise(double A = 0, Steps Steps = Steps.None) { return 0; }
        public static double  Step(double A = 0, double Threshold = 0.5, double Value_under = 0.0, double Value_over = 1.0) { return 0; }
        public static double  Round(double A = 0, Rounding_Mode Rounding_Mode = Rounding_Mode.Floor) { return 0; }
    }
    public class Clamping
    {
        public (double, double) Switch(double A = 0, double B = 0) { return(0, 0); }
        public static double  Max(double A = 0, double B = 0) { return 0; }
        public static double  Min(double A = 0, double B = 0) { return 0; }
        public static double  Mix(double A = 0, double B = 0, double C = 0) { return 0; }
        public static double  Clamp(double A = 0, double Lower = 0.0, double Upper = 1.0) { return 0; }
        public static double  Remap(double A = 0, bool Clamp_Output = true, double Input_lower = 0, double Input_Upper = 1, double Output_Lower = 0, double Output_Upper = 1) { return 0; }
    }
    public class Debuging
    {
        public enum Location
        {
            Lower_Left,
            Lower_Right
        }
        public enum Precision
        {
            Integer,
            Once_Decimal,
            Two_Decimal
        }
        public enum Wave_Type
        {
            Sine,
            Square,
            Triangle
        }
        public static double  Noise() { return 0; }
        public static double  Time() { return 0; }
        public static double  Debug(double A = 0, Location Location = Location.Lower_Left, Precision Precision = Precision.Integer, string Unit = "", double Multiplier = 1.0, string Name = "", double Priority = 0) { return 0; }
        public static double  Through(double A = 0) { return 0; }
        public static double  SmoothNoise(double A = 0, double Seed = 0.0) { return 0; }
        public static double  Wave(double Amplitude = 1.0, double Phase = 0.0, double Period = 3.0, double Skew = 0.0, Wave_Type Wave_Type = Wave_Type.Sine) { return 0; }
    }
    public class State
    {
        public static double  Delay(double A = 0, double Seconds = 0.5) { return 0; }
        public static double  Edge(double A = 0, double Value_On = 1.0, double Value_Off = 0.0, double Threshold = 0.5, bool Falling_Edges = false) { return 0; }
        public static double  FlipFlop(double A = 0, double B = 0, double C = 0) { return 0; }
        public static double  Hold(double A = 0, double Threshold = 0.5, double Durantion = 1.0, bool Refresh = false) { return 0; }
        public static double  Memory(double A = 0, double B = 0) { return 0; }
        public static double  PID(double A = 0, double B = 0, double Kp = 1.0, double Ki = 0.0, double KdKi = 0.0, double Clamp_IntegralKi = 0.0, double Clamp_Derivative = 0.0) { return 0; }
        public (double, double) Sequence(List<double> Sequence, double A = 0, bool Smooth = false, double Durration = 4, bool Semitonic = false) { return (0,0); }
        public static double  Toggle(double A = 0, double B = 0, double Value_On = 1.0, double Value_Off = 0.0, double Threshold = 0.5) { return 0; }
        public static double  Average(double A = 0, double Seconds = 2.0) { return 0; }
    }
    public class Sequence 
    {
        public double  Step_Amount;

        public double  seq1;
        public double  seq2;
        public double  seq3;
        public double  seq4;
        public double  seq5;
        public double  seq6;
        public double  seq7;
        public double  seq8;

        public double  seq9;
        public double  seq10;
        public double  seq11;
        public double  seq12;
        public double  seq13;
        public double  seq14;
        public double  seq15;
        public double  seq16;

        public double  seq17;
        public double  seq18;
        public double  seq19;
        public double  seq20;
        public double  seq21;
        public double  seq22;
        public double  seq23;
        public double  seq24;

        public double  seq25;
        public double  seq26;
        public double  seq27;
        public double  seq28;
        public double  seq29;
        public double  seq30;
        public double  seq31;
        public double  seq32;

        public static Sequence NewSequence(List<double> DoubleList)
        {
            var L = DoubleList;
            var Length = DoubleList.Count;
            int Count = 0;
            while (Length > 8)
            {
                Length -= 8;
                Count++;
            }
            if (Count > 2)
                Count = 4;
            return new Sequence
            {
                Step_Amount = Count,

                seq1 = L[0],
                seq2 = L[2],
                seq3 = L[3],
                seq4 = L[4],
                seq5 = L[5],
                seq6 = L[6],
                seq7 = L[7],
                seq8 = L[8],

                seq9 = L[9],
                seq10 = L[10],
                seq11 = L[11],
                seq12 = L[12],
                seq13 = L[13],
                seq14 = L[14],
                seq15 = L[15],
                seq16 = L[16],

                seq17 = L[17],
                seq18 = L[18],
                seq19 = L[19],
                seq20 = L[20],
                seq21 = L[21],
                seq22 = L[22],
                seq23 = L[23],
                seq24 = L[24],

                seq25 = L[25],
                seq26 = L[26],
                seq27 = L[27],
                seq28 = L[28],
                seq29 = L[29],
                seq30 = L[30],
                seq31 = L[31],
                seq32 = L[32]
            };
        }
    }

    public class Logic
    {
        public static double  Compare(double A = 0, double B = 0) { return 0; }
        public static double  Equals(double A = 0, double B = 0) { return 0; }
        public static double  And(double A = 0, double B = 0) { return 0; }
        public static double  NotAnd(double A = 0, double B = 0) { return 0; }
        public static double  Or(double A = 0, double B = 0) { return 0; }
        public static double  ExclusiveOr(double A = 0) { return 0; }
        public static double  Binary(double A = 0) { return 0; }
        public static double  Not(double A = 0, double B = 0) { return 0; }
    }
    public class Trig
    {
        public static double  ATan2(double A = 0, double B = 0) { return 0; }
        public static double  ACos(double A = 0) { return 0; }
        public static double  ASin(double A = 0) { return 0; }
        public static double  ATan(double A = 0) { return 0; }
        public static double  Cos(double A = 0) { return 0; }
        public static double  Sin(double A = 0) { return 0; }
        public static double  Tan(double A = 0) { return 0; }

    }
    class Controls
    {
        public static double CreateInput(Keyboard.Key Positive = Keyboard.Key.NONE, Keyboard.Key Negative = Keyboard.Key.NONE)
        {
            return 0;
        }
        public static double CreateOutput(/* idk wut goes here*/)
        {
            return 0;
        }
    }
    public class Parts
    {
        public static string[] PartLocations = new string[]
        {
            "MM",
            "ML",
            "MR",
            "BM",
            "BL",
            "BR"
        };
        public static PartLocation ParsePartLocation(string loc)
        {
            PartLocation RETURN;
            Enum.TryParse(loc, out RETURN);
            if(RETURN != new PartLocation()) { return RETURN; } else { return PartLocation.NONE; }
        }
        public static PartList ParsePart(string PartName)
        {
            PartList RETURN;
            Enum.TryParse(PartName, out RETURN);
            if(RETURN != new PartList()) { return RETURN; } else { return PartList.NONE; }
        }
        public static PartList GetPartName(string FullName)
        {
            foreach (string item in PartLocations)
            {
                if (FullName.Contains(item))
                {
                    return ParsePart(FullName.Split(item)[0].Remove(FullName.Split(item)[0].Length - 1));
                }
            }
            return PartList.NONE;
        }
        public static PartLocation GetPartLocation(string FullName)
        {
            foreach (string item in PartLocations)
            {
                if (FullName.Contains(item))
                {
                    return ParsePartLocation(item);
                }
            }
            return PartLocation.NONE;
        }
        public static string GetPartId(string FullName)
        {
            return FullName.Split("_")[^1];
        }
    }
    public enum PartLocation
    {
        NONE,
        MM,
        ML,
        MR,
        BM,
        BL,
        BR
    };
    public enum PartList
    {
        NONE,
        accelerometer_sensor_01,
        antigravity_steering_01,
        audio_emitter_01,
        booster_01,
        camera_01,
        depth_sensor_01,
        detachable_01,
        emergency_beacon_01,
        gps_sensor_01,
        gyroscope_sensor_01,
        head_light_01,
        head_light_02,
        head_light_03,
        hinge_powered_pitch_01,
        hinge_powered_pitch_02,
        jet_engine_01,
        led_bar_small_01,
        led_tricolor_01,
        light_auxiliary_01,
        light_indicator_01,
        light_indicator_02,
        motor_00_small,
        motor_01,
        motor_01_large,
        periscope_01,
        piston_01,
        piston_01_small,
        proximity_sensor_01,
        rcs_thruster_01,
        segmentdisplay_01a,
        servo_01,
        servo_02,
        smart_sensor_01,
        suction_pad_01,
        tail_light_01,
        tail_light_02,
        tail_light_03,
        trailmaker_01,
        trailmaker_02,
        wheel_hub_00_small,
        wheel_hub_01,
        wheel_hub_01_large,
        wheel_hub_02_large,
        wheel_hub_02_medium,
        wheel_hub_02_small
    }
    public struct Programables
    {
        public static Programables NewPart(string FullName, string CustomName = "default")
        {
            return new Programables
            {
                PartName = Parts.GetPartName(FullName),
                Location = Parts.GetPartLocation(FullName),
                Id = Parts.GetPartId(FullName),
                Name = CustomName,
                FullName = FullName
            };
        }
        public PartList PartName { get; set; }
        public PartLocation Location { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
    public struct ProgramableProperties
    {
        public static ProgramableProperties AddProperty(JObject Properties, Programables ProgramablePart)
        {
            return new ProgramableProperties
            {
                Properties = Properties,
                ProgramablePart = ProgramablePart
            };
        }
        public JObject Properties { get; set; }
        public Programables ProgramablePart { get; set; }
    }
    public struct ObjectProperties
    {
        public static ObjectProperties AddProperty(List<string> Props, List<string> values)
        {
            ObjectProperties properties = new();
            int index = 0;
            foreach (var item in Props)
            {
                switch (item)
                {
                    case "Juice":
                        properties.Juice = float.Parse(values[index]);
                        break;
                    case "torque_adjust":
                        properties.torque_adjust = float.Parse(values[index]);
                        break;
                    case "Acceleration":
                        properties.Acceleration = float.Parse(values[index]);
                        break;
                    case "motor_full_braking":
                        properties.motor_full_braking = Convert.ToBoolean(int.Parse(values[index]));
                        break;
                    case "angle_unit":
                        properties.angle_unit = int.Parse(values[index]);
                        break;
                    case "steering_angle":
                        properties.steering_angle = float.Parse(values[index]);
                        break;
                    case "camber_angle":
                        properties.camber_angle = float.Parse(values[index]);
                        break;
                    case "motor_sound":
                        properties.Juice = float.Parse(values[index]);
                        break;
                    case "braking_strength":
                        properties.braking_strength = float.Parse(values[index]);
                        break;
                    case "antigravity_distance":
                        properties.antigravity_distance = float.Parse(values[index]);
                        break;
                    case "antigravity_lean":
                        properties.antigravity_lean = float.Parse(values[index]);
                        break;
                    case "angle_limit_full":
                        properties.angle_limit_full = Quat.Parse(values[index]);
                        break;
                    case "audio_volume":
                        properties.audio_volume = float.Parse(values[index]);
                        break;
                    case "angle_speed":
                        properties.angle_speed = float.Parse(values[index]);
                        break;
                    case "self_collision":
                        properties.self_collision = float.Parse(values[index]);
                        break;
                    case "motor_strength":
                        properties.motor_strength = float.Parse(values[index]);
                        break;
                    case "length_limit":
                        properties.angle_limit_full = Quat.Parse(values[index]);
                        break;
                    case "suction_range_of_motion":
                        properties.suction_range_of_motion = float.Parse(values[index]);
                        break;
                    case "suction_release_impulse":
                        properties.suction_release_impulse = float.Parse(values[index]);
                        break;
                    case "sensor_range":
                        properties.sensor_range = float.Parse(values[index]);
                        break;
                    case "smart_target":
                        properties.smart_target = float.Parse(values[index]);
                        break;
                    case "camera_fov":
                        properties.camera_fov = float.Parse(values[index]);
                        break;
                    case "audio_sample":
                        properties.audio_sample = float.Parse(values[index]);
                        break;
                    case "digit":
                        properties.digit = float.Parse(values[index]);
                        break;
                    case "sign_only":
                        properties.sign_only = Convert.ToBoolean(int.Parse(values[index]));
                        break;
                    case "trailMaker_type":
                        properties.trailMaker_type = int.Parse(values[index]);
                        break;
                }
                index++;
            }
            Debug.WriteLine(properties.ToString());
            return properties;
        }

        float Juice { get; set; }
        float torque_adjust { get; set; }
        float Acceleration { get; set; }
        bool motor_full_braking { get; set; }
        int angle_unit { get; set; }
        float steering_angle { get; set; }
        float camber_angle { get; set; }
        float motor_sound { get; set; }
        float braking_strength { get; set; }
        float antigravity_distance { get; set; }
        float antigravity_lean { get; set; }
        Quaternion angle_limit_full { get; set; }
        float audio_volume { get; set; }
        float angle_speed { get; set; }
        float self_collision { get; set; }
        float motor_strength { get; set; }
        Quaternion length_limit { get; set; }
        float suction_range_of_motion { get; set; }
        float suction_release_impulse { get; set; }
        float sensor_range { get; set; }
        float smart_target { get; set; }
        float camera_fov { get; set; }
        float audio_sample { get; set; }
        float digit { get; set; }
        bool sign_only { get; set; }
        int trailMaker_type { get; set; }
    }
    public class Quat
    {
        public static Quaternion Parse(string quat)
        {
            char[] nums = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            quat = quat.Replace("{", "").Replace("}", "").Replace(Environment.NewLine, "");
            var quats = quat.Split(",");
            List<float> list = new List<float>()
            {
                0,
                0,
                0,
                0,
            };
            for (var i = 0; i < 4; i++)
            {
                string pos = quats[i];
                var index = 0;
                foreach (char c in quats[i])
                {
                    if (!nums.Contains(c))
                    {
                        pos = pos.Remove(index, 1);
                        index--;
                    }
                    index++;
                }
                list[i] = float.Parse(pos);
            }
            return new Quaternion() { X = list[0], Y = list[1], Z = list[2], W = list[3] };
        }
    }
    public static class Keyboard
    {
        public static Key KeyInput(string KeyButton)
        {
            /*
            switch (KeyButton.ToUpper())
            {
                case "A":
                    return Key.A;
                case "B":
                    return Key.B;
                case "C":
                    return Key.C;
                case "D":
                    return Key.D;
                case "E":
                    return Key.E;
                case "F":
                    return Key.F;
                case "G":
                    return Key.G;
                case "H":
                    return Key.H;
                case "I":
                    return Key.I;
                case "J":
                    return Key.J;
                case "K":
                    return Key.K;
                case "L":
                    return Key.L;
                case "M":
                    return Key.M;
                case "N":
                    return Key.N;
                case "O":
                    return Key.O;
                case "P":
                    return Key.P;
                case "Q":
                    return Key.Q;
                case "R":
                    return Key.R;
                case "S":
                    return Key.S;
                case "T":
                    return Key.T;
                case "U":
                    return Key.U;
                case "V":
                    return Key.V;
                case "W":
                    return Key.W;
                case "X":
                    return Key.X;
                case "Y":
                    return Key.Y;
                case "Z":
                    return Key.Z;
                case "F1":
                    return Key.F1;
                case "F2":
                    return Key.F2;
                case "F3":
                    return Key.F3;
                case "F4":
                    return Key.F4;
                case "F5":
                    return Key.F5;
                case "F6":
                    return Key.F6;
                case "F7":
                    return Key.F7;
                case "F8":
                    return Key.F8;
                case "F9":
                    return Key.F9;
                case "F10":
                    return Key.F10;
                case "F11":
                    return Key.F11;
                case "F12":
                    return Key.F12;
            }
            */
            return Key.A;
        }
        public enum Key
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I,
            J,
            K,
            L,
            M,
            N,
            O,
            P,
            Q,
            R,
            S,
            T,
            U,
            V,
            W,
            X,
            Y,
            Z,
            F1,
            F2,
            F3,
            F4,
            F5,
            F6,
            F7,
            F8,
            F9,
            F10,
            F11,
            F12,
            NONE
        }
    }
}