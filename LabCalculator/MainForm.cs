using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Forms;

namespace LabCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            SolveExpression();
        }

        private void ExpressionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleEnterPress(e);
        }

        private void MinValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleEnterPress(e);
            HandleDigit(sender, e);
        }

        private void MaxValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleEnterPress(e);
            HandleDigit(sender, e);
        }

        private void StepsNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleEnterPress(e);
        }


        private void HandleEnterPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                e.Handled = true;
                SolveExpression();
            }
        }

        private void HandleDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }

            HandleDigitDot(sender, e);
            HandleDigitMinus(sender, e);
        }

        private void HandleDigitDot(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if ((sender as TextBox).Text.IndexOf('.') < 0)
                {
                    return;
                }
                else if ((sender as TextBox).SelectedText.IndexOf('.') >= 0)
                {
                    return;
                }

                e.Handled = true;
                return;
            }
        }

        private void HandleDigitMinus(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                if ((sender as TextBox).Text.IndexOf('-') < 0)
                {
                    if ((sender as TextBox).SelectionStart == 0)
                    {
                        return;
                    }

                    e.Handled = true;
                    return;
                }
                else if ((sender as TextBox).SelectedText.IndexOf('-') >= 0 &&
                    (sender as TextBox).SelectionStart == 0)
                {
                    return;
                }

                e.Handled = true;
                return;
            }
        }


        private void SolveExpression()
        {
            if (!GetValue(minValueTextBox.Text, out double minValue, out string errorMessage))
            {
                ShowErrorMessage(errorMessage);
                return;
            }

            if (!GetValue(maxValueTextBox.Text, out double maxValue, out errorMessage))
            {
                ShowErrorMessage(errorMessage);
                return;
            }

            int stepAmount = (int) stepsNumericUpDown.Value;

            double[] xs = new double[stepAmount];
            double[] ys = new double[stepAmount];

            if (!CalculateValues(minValue, maxValue, xs, ys, out errorMessage))
            {
                ShowErrorMessage(errorMessage);
                return;
            }

            UpdateDataGridView(xs, ys);
            UpdateCartesianChart(xs, ys);
        }

        private void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool GetValue(string text, out double value, out string errorMessage)
        {
            try
            {
                value = double.Parse(text);
                errorMessage = "";
                return true;
            }
            catch (Exception e)
            {
                value = 0.0;
                errorMessage = e.Message;
                return false;
            }
        }

        private bool CalculateValues(double minValue, double maxValue,
            double[] xs, double[] ys,
            out string errorMessage)
        {
            string expression = expressionTextBox.Text;
            if (expression == "")
            {
                expression = "0";
            }

            int stepAmount = xs.Length;

            for (int i = 0; i < stepAmount; ++i)
            {
                double t = i / ((double) stepAmount - 1);
                t = Clamp01(t);

                double x = Lerp(minValue, maxValue, t);

                xs[i] = x;

                if (Calculator.Evaluate(expression, x,
                    out double result, out errorMessage))
                {
                    ys[i] = result;
                }
                else
                {
                    return false;
                }
            }

            errorMessage = "";

            return true;
        }

        private void UpdateDataGridView(double[] xs, double[] ys)
        {
            functionDataGridView.Rows.Clear();

            for (int i = 0; i < xs.Length; ++i)
            {
                functionDataGridView.Rows.Add(xs[i], ys[i]);
            }
        }

        private void UpdateCartesianChart(double[] xs, double[] ys)
        {
            LineSeries lineSeries = new()
            {
                Title = "Y",
                Values = new ChartValues<ObservablePoint>()
            };

            for (int i = 0; i < xs.Length; ++i)
            {
                ObservablePoint observablePoint = new(xs[i], ys[i]);
                lineSeries.Values.Add(observablePoint);
            }

            functionCartesianChart.Series = new SeriesCollection
            {
                lineSeries
            };
        }

        private double Lerp(double a, double b, double t)
        {
            return a * (1.0 - t) + b * t;
        }

        private double Clamp01(double x)
        {
            return Clamp(0.0, 1.0, x);
        }

        private double Clamp(double min, double max, double x)
        {
            return Math.Max(min, Math.Min(max, x));
        }
    }
}
