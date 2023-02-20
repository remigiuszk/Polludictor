using MathNet.Numerics.LinearAlgebra;
using System.Globalization;

namespace Polludictor.Applicaton.Services
{
    public class KarkatService
    {
        public Matrix<double> Matrix { get; set; }

        private int window;
        private int numberOfSimulations;
        private int predictionHorizon;


        public KarkatService()
        {
            LoadData();
        }

        private void LoadData()
        {
            var rows = File.ReadLines("data.txt").ToArray();

            var dataArray = new double[rows.Length][];
            var format = new NumberFormatInfo();
            format.NegativeSign = "-";
            format.NumberDecimalSeparator = ".";

            for (int i = 0; i < rows.Length; i++)
            {
                var array = rows[i].Split(';');

                var arrayOfDoubles = new double[array.Length];

                for (int j = 0; j < array.Length; j++)
                {
                    var cell = array[j];
                    arrayOfDoubles[j] = Double.Parse(cell, format);
                }

                dataArray[i] = arrayOfDoubles;
            }

            var marixBuilder = Matrix<double>.Build;
            Matrix = marixBuilder.DenseOfColumnArrays(dataArray).Transpose();

            PreparePrerequisiteData();
        }


        private void PreparePrerequisiteData()
        {
            predictionHorizon = 1;
            window = 5;
            numberOfSimulations = 300;
            var beg1 = Matrix.RowCount - numberOfSimulations - window - predictionHorizon;

            for (int i = 1; i <= numberOfSimulations; i++)
            {
                var beg = beg1 + i;
                var windowFinish = beg + window;
                var cn = Matrix[windowFinish + predictionHorizon-1, 0];
                var c1 = Matrix.SubMatrix(beg-1, windowFinish - beg+1, 1, 1);
                c1 = c1.Append(Matrix.SubMatrix(beg-1, windowFinish - beg+1, 3, 1));
                c1 = c1.Append(Matrix.SubMatrix(beg-1, windowFinish - beg+1, 4, 1));
                c1 = c1.Append(Matrix.SubMatrix(beg-1, windowFinish - beg+1, 7, 1));

                var c1Print = c1.ToString();

                var valueToPredict = Matrix.SubMatrix(beg + predictionHorizon-1, (windowFinish + predictionHorizon) - (beg + predictionHorizon+1), 0, 1);

                var valueString = valueToPredict.ToString();

            }
        }
    }
}

