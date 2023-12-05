using System.ComponentModel.DataAnnotations;

namespace BMICalculatorApp.Models
{
    public class BmiViewModel
    {

        [Required(ErrorMessage = "Please enter a Height in metres.")]
        [Range(0.01, 3, ErrorMessage = "Height must be greater than 0 and less than or equal to 3.")]
        public double Height { get; set; }


        [Required(ErrorMessage = "Please enter a Weight in Kg.")]
        
        public double Weight { get; set; }



        public double Bmi { get; set; }

        public double CalcBmi(double height, double weight)
        {
            Height = height;
            Weight = weight;
            Bmi = weight / (Height * Height);

            return Bmi;
        }

        public string? BmiSummary { get; set; }

        public  string GetBmiResultSummary(double? bmi)
        {
            string summary;
            if (bmi > 0.0 && bmi < 18.5)
                summary = "underweight";
            else if (bmi >= 18.5 && bmi < 25.0)
                summary = "normal";
            else if (bmi >= 25.0 && bmi < 30.0)
                summary = "overweight";
            else if (bmi >= 30.0)
                summary = "obese";
            else
                summary = "indetermined";

            return summary;
        }


    }
}
