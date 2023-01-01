using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class SeriesQuantileComputing
    {
        public double ComputePhisherQuantile(double p, int v1, int v2)
        {
            var expr1 = ComputeNormalSeriesQuantile(p) * Math.Sqrt(ComputeSigma(v1, v2) / 2);
            var expr2 = (double)1 / 6 * ComputeDelta(v1, v2) * (Math.Pow(ComputeNormalSeriesQuantile(p), 2) + 2);
            var subExpr1 = ComputeSigma(v1, v2) / 24 * (Math.Pow(ComputeNormalSeriesQuantile(p), 2) + 3 * ComputeNormalSeriesQuantile(p));
            var subExpr2 = (double)1 / 72 * (ComputeDelta(v1, v2, 2) / ComputeSigma(v1, v2)) * (Math.Pow(ComputeNormalSeriesQuantile(p), 3) + 11 * ComputeNormalSeriesQuantile(p));
            var expr3 = Math.Sqrt(ComputeSigma(v1, v2) / 2) * (subExpr1 + subExpr2);
            var expr4 = (ComputeDelta(v1, v2) * ComputeSigma(v1, v2)) / 120 * (Math.Pow(ComputeNormalSeriesQuantile(p), 4) + 9 * Math.Pow(ComputeNormalSeriesQuantile(p), 2) + 8);
            var expr5 = ComputeDelta(v1, v2, 3) / (3240 * ComputeSigma(v1, v2)) * (3 * Math.Pow(ComputeNormalSeriesQuantile(p), 4) + 7 * Math.Pow(ComputeNormalSeriesQuantile(p), 2) - 16);
            var subExpr3 = ComputeSigma(v1, v2, 2) / 1920 * (Math.Pow(ComputeNormalSeriesQuantile(p), 5) + 20 * Math.Pow(ComputeNormalSeriesQuantile(p), 3) + 15 * ComputeNormalSeriesQuantile(p));
            var subExpr4 = ComputeSigma(v1, v2, 4) / 2880 * (Math.Pow(ComputeNormalSeriesQuantile(p), 5) + 44 * Math.Pow(ComputeNormalSeriesQuantile(p), 3) + 183 * ComputeNormalSeriesQuantile(p));
            var subExpr5 = ComputeSigma(v1, v2, 4) / (155520 * ComputeSigma(v1, v2, 2)) * (9 * Math.Pow(ComputeNormalSeriesQuantile(p), 5) - 284 * Math.Pow(ComputeNormalSeriesQuantile(p), 3) - 1513 * ComputeNormalSeriesQuantile(p));
            var expr6 = Math.Sqrt(ComputeSigma(v1, v2) / 2) * (subExpr3 + subExpr4 + subExpr5);
            var z = expr1 - expr2 + expr3 - expr4 + expr5 + expr6;
            return Math.Exp(2 * z);
        }
        public double ComputeStudentQuantile(double p, int v)
        {
            var up = ComputeNormalSeriesQuantile(p);
            var g1 = 0.25 * (Math.Pow(up, 3) + up);
            var g2 = (double)1 / 96 * (5 * Math.Pow(up, 5) + 16 * Math.Pow(up, 3) + 3 * up);
            var g3 = (double)1 / 384 * (3 * Math.Pow(up, 7) + 19 * Math.Pow(up, 5) + 17 * Math.Pow(up, 3) - 15 * up);
            var g4 = (double)1 / 92160 * (79 * Math.Pow(up, 9) + 779 * Math.Pow(up, 7) + 1482 * Math.Pow(up, 5) - 1920 * Math.Pow(up, 3) - 945 * up);
            var prefix = (double)1 / v;

            return up + prefix * g1 + Math.Pow(prefix, 2) * g2 + Math.Pow(prefix, 3) * g3 + Math.Pow(prefix, 4) * g4;
        }

        public double ComputeDelta(int v1, int v2, int exp = 1)
        {
            return Math.Pow(((double)1 / v1) - ((double)1 / v2), exp);
        }

        public double ComputeSigma(int v1, int v2, int exp = 1)
        {
            return Math.Pow(((double)1 / v1) + ((double)1 / v2), exp);
        }

        public double ComputeNormalSeriesQuantile(double p)
        {
            return p <= 0.5 ? -ComputePhi(p) : ComputePhi(1 - p);
        }

        private double ComputePhi(double a)
        {
            var t = Math.Sqrt(-2 * Math.Log(a));
            var c0 = 2.515517;
            var c1 = 0.802853;
            var c2 = 0.010328;
            var d1 = 1.432788;
            var d2 = 0.1892659;
            var d3 = 0.001308;

            return t - (c0 + c1 * t + c2 * Math.Pow(t, 2)) / (1 + d1 * t + d2 * Math.Pow(t, 2) + d3 * Math.Pow(t, 3));
        }
    }
}
