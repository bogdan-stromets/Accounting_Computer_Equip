using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CourseWork
{
    enum EaseType
    {
        Linear,
        QuadraticIn,
        QuadraticOut,
        CubicIn,
        CubicOut,
        CubicInOut,
        QuarterIn,
        CirculInOut, CirculOut ,
        CirculIn,
        ExpInOut,
        ExpOut,
        ExpIn,
        SinInOut,
        SinOut,
        SinIn,
        QuinticInOut,
        QuinticOut,
        QuinticIn,
        QuarterInOut,
        QuarterOut
    }
    internal struct Ease
    {
        private double t, startValue, changeValue, duration;
        private double result = 0;
        private delegate double EaseMethod();

        public double GetValue => result; 
       
        public Ease(double t,double startValue, double changeValue, double duration,EaseType type = EaseType.Linear)
        {
            this.t = t;
            this.startValue = startValue;
            this.changeValue = changeValue;
            this.duration = duration;

            EaseMethod func;
            switch (type)
            {
                    case EaseType.SinOut: func = SinOut; break;
                    case EaseType.SinInOut: func = SinInOut; break;
                    case EaseType.SinIn: func = SinIn; break;
                    case EaseType.QuinticOut: func = QuinticOut; break;
                    case EaseType.QuinticInOut: func = QuinticInOut; break;
                    case EaseType.QuinticIn: func = QuinticIn;  break;
                    case EaseType.QuarterOut: func = QuarterOut; break;
                    case EaseType.QuarterInOut: func = QuarterInOut; break;
                    case EaseType.QuarterIn: func = QuarterIn; break;
                    case EaseType.QuadraticOut: func = QuadraticOut; break;
                    case EaseType.QuadraticIn: func = QuadraticIn; break;
                    case EaseType.Linear: func = Linear; break;
                    case EaseType.ExpOut: func = ExpOut; break;
                    case EaseType.ExpInOut: func = ExpInOut; break;
                    case EaseType.ExpIn: func = ExpIn; break;
                    case EaseType.CubicOut: func = CubicOut; break;
                    case EaseType.CubicInOut: func = CubicInOut; break;
                    case EaseType.CubicIn: func = CubicIn; break;
                    case EaseType.CirculOut: func = CirculOut; break;
                    case EaseType.CirculInOut: func = CirculInOut; break;
                    case EaseType.CirculIn: func = CirculIn; break;
                    default: func = Linear; break;
            }
            result = func();
        }

        
        double Linear()
        {
            return changeValue * t / duration + startValue;
        }     
        double QuadraticIn()
        {
            t /= duration;
            return changeValue * Math.Pow(t, 2) + startValue;
        }
        double QuadraticOut()
        {
            t /= duration / 2;
            if (t < 1)
            {
                return changeValue / 2 * Math.Pow(t, 2) + startValue;
            }
            return -changeValue / 2 * (t * (t - 2) - 1) + startValue;
        }     
        double CubicIn()
        {
            t /= duration;
            return changeValue * Math.Pow(t, 3) + startValue;
        }     
        double CubicOut()
        {
            t /= duration;
            t--;
            return changeValue * (Math.Pow(t, 3) + 1) + startValue;
        }
        double CubicInOut()
        {
            t /= duration / 2;
            if (t < 1)
            {
                return changeValue / 2 * Math.Pow(t, 3) + startValue;
            }
            t -= 2;
            return changeValue / 2 * (Math.Pow(t, 3) + 2) + startValue;
        }
        double QuarterIn()
        {
            t /= duration;
            return changeValue * Math.Pow(t, 4) + startValue;
        }
        double QuarterOut()
        {
            t /= duration;
            t--;
            return -changeValue * (Math.Pow(t, 4) - 1) + startValue;
        }
        double QuarterInOut()
        {
            t /= duration / 2;
            if (t < 1)
            {
                return changeValue / 2 * Math.Pow(t, 4) + startValue;
            }
            t -= 2;
            return -changeValue / 2 * (Math.Pow(t, 4) - 2) + startValue;
        }
        double QuinticIn()
        {
            t /= duration;
            return changeValue * Math.Pow(t, 5) + startValue;
        }
        double QuinticOut()
        {
            t /= duration;
            t--;
            return changeValue * (Math.Pow(t, 5) + 1) + startValue;
        }
        double QuinticInOut()
        {
            t /= duration / 2;
            if (t < 1)
            {
                return changeValue / 2 * Math.Pow(t, 5) + startValue;
            }
            t -= 2;
            return changeValue / 2 * (Math.Pow(t, 5) + 2) + startValue;
        }
        double SinIn()
        {
            return -changeValue * Math.Cos(t / duration * (Math.PI / 2)) + changeValue + startValue;
        }
        double SinOut()
        {
            return changeValue * Math.Sin(t / duration * (Math.PI / 2)) + changeValue + startValue;
        }
        double SinInOut()
        {
            return -changeValue / 2 * (Math.Cos(Math.PI * t / duration) - 1) + startValue;
        }
        double ExpIn()
        {
            return changeValue * Math.Pow(2, 10 * (t / duration - 1)) + startValue;
        }
        double ExpOut()
        {
            return changeValue * (-Math.Pow(2, -10 * t / duration) + 1) + startValue;
        }
        double ExpInOut()
        {
            t /= duration / 2;
            if (t < 1)
            {
                return changeValue / 2 * Math.Pow(2, 10 * (t - 1)) + startValue;
            }
            t--;
            return changeValue / 2 * (-Math.Pow(2, -10 * t) + 2) + startValue;
        }
        double CirculIn()
        {
            t /= duration;
            return -changeValue * (Math.Sqrt(1 - Math.Pow(t, 2)) - 1) + startValue;
        }
        double CirculOut()
        {
            t /= duration;
            t--;
            return changeValue * Math.Sqrt(1 - Math.Pow(t, 2)) + startValue;
        }
        double CirculInOut()
        {
            t /= duration / 2;
            if (t < 1)
            {
                return -changeValue / 2 * (Math.Sqrt(1 - Math.Pow(t, 2)) - 1) + startValue;
            }
            t -= 2;
            return changeValue / 2 * (Math.Sqrt(1 - Math.Pow(t, 2) + 1) + startValue);
        }
    }
}
