﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CPS
{
    [Serializable]
    class SygnalSinWyprostowanyJednoPolowkowo: Sygnal
    {
        public SygnalSinWyprostowanyJednoPolowkowo(double A, double T, double t1, double d) 
        {
            this.A = A;
            this.T = T;
            this.t1 = t1;
            this.d = d;
            signalName = "Sygnał sinusoidalny wyprostowany jednopołówkowo";
            IsDiscreteSignal = false;
        }

        public SygnalSinWyprostowanyJednoPolowkowo() { }

        public override void CalculateXYPoints() {
            axisX.Clear();
            axisY.Clear();

            for (double i = t1; i < (d + t1); i = i + (1 / f)) {
                axisX.Add(i);
                axisY.Add(0.5 * A * (Math.Sin(((2 * Math.PI) / T) * (i - t1)) + Math.Abs(Math.Sin(((2 * Math.PI) / T) * (i - t1)))));
            }
        }

        public override List<double> CalculateYPoints(List<double> axisX) {

            List<double> rAxisY = new List<double>();

            foreach (var point in axisX) {
                rAxisY.Add(0.5 * A * (Math.Sin(((2 * Math.PI) / T) * (point - t1)) + Math.Abs(Math.Sin(((2 * Math.PI) / T) * (point - t1)))));
            }

            return rAxisY;
        }

        public override Sygnal GetNewSignal() {
            return new SygnalSinWyprostowanyJednoPolowkowo();
        }
    }
}