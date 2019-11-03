using System;
using System.Numerics;
using System.Units;
using System.Units.Time;
using System.Units.Length;
using System.Units.Velocity;
using System.Units.Acceleration;
using System.Units.Angle;

using SecondsType = System.Units.Quantity<double, System.Units.Time.Second>;
using SpeedType = System.Units.Quantity<double, System.Units.Velocity.MetrePerSecond>;
using AccelerationType = System.Units.Quantity<double, System.Units.Acceleration.MetrePerSecondSq>;
using AngleType = System.Units.Quantity<double, System.Units.Angle.Radians>;
using PositionType = System.Units.Quantity<System.Numerics.Vector2, System.Units.Length.Metre>;

namespace Tutorials.Tutorial1 {
    public class Projectile {
        
        public SpeedType Vx { get; private set; }
        public SpeedType Vy { get; private set; }
        public AngleType LaunchAngle { get; private set; }

        public Projectile(SpeedType speed, AngleType angle) {
            this.LaunchAngle = angle;
            this.Vx = (speed.Value * Math.Cos(angle.Value)).m_s();
            this.Vy = (speed.Value * Math.Sin(angle.Value)).m_s();
        }

        public static readonly AccelerationType g = 9.8.m_s2();

        public PositionType this[SecondsType t] {
            get {
                double xt = this.Vx.Value * t.Value;
                double yt = this.Vy.Value * t.Value - (0.5) * g.Value * (t.Value * t.Value);

                return (new Vector2((float)xt, (float)yt)).m();
            }
        }

    }

    public class Program {
        public static void Run() {
            Projectile p1 = new Projectile(12.0.m_s(), 0.78.rad());

            var PositionAt1s = p1[1.0.s()];
            var PositionAt2s = p1[2.0.s()];

            Console.WriteLine(string.Format("At {0}, the position of the projectile will be at {1}.", 1.s(), PositionAt1s));
            Console.WriteLine(string.Format("At {0}, the position of the projectile will be at {1}.", 2.s(), PositionAt2s));
        }
    }
}