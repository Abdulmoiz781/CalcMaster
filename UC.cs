using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMaster
{
    public partial class UC : Form
    {
        public UC()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            ThemeManager.LoadTheme();       // Line 1 ✅ Load from file
            ThemeManager.ApplyTheme(this);  // Line 2 ✅ Apply to this form
        }


        private void UnitConverterForm_Load(object sender, EventArgs e)
        {
            // Ensure the ComboBox is populated correctly
            comboBoxConversionType.Items.Clear(); // Clear any previous items (just to be safe)

            // Add Conversion Type options (Length, Weight, Temperature)
            comboBoxConversionType.Items.Add("Length");
            comboBoxConversionType.Items.Add("Weight");
            comboBoxConversionType.Items.Add("Temperature");

            // Set the default selected item (optional)
            comboBoxConversionType.SelectedIndex = 0; // Default to "Length"
        }

        private void comboBoxConversionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate units based on selected conversion type
            string selectedConversionType = comboBoxConversionType.SelectedItem.ToString();
            PopulateUnits(selectedConversionType);
        }

        private void PopulateUnits(string conversionType)
        {
            // Clear previous items in From and To Unit ComboBoxes
            comboBoxFromUnit.Items.Clear();
            comboBoxToUnit.Items.Clear();


            if (conversionType == "Length")
            {
                // Length Conversion Units
                comboBoxFromUnit.Items.Add("Millimetre");
                comboBoxFromUnit.Items.Add("Centimetre");
                comboBoxFromUnit.Items.Add("Metre");
                comboBoxFromUnit.Items.Add("Kilometre");
                comboBoxFromUnit.Items.Add("Mile");
                comboBoxFromUnit.Items.Add("NauticalMile");
                comboBoxFromUnit.Items.Add("Inch");
                comboBoxFromUnit.Items.Add("Foot");
                comboBoxFromUnit.Items.Add("Yard");


                comboBoxToUnit.Items.Add("Millimetre");
                comboBoxToUnit.Items.Add("Centimetre");
                comboBoxToUnit.Items.Add("Metre");
                comboBoxToUnit.Items.Add("Kilometre");
                comboBoxToUnit.Items.Add("Mile");
                comboBoxToUnit.Items.Add("NauticalMile");
                comboBoxToUnit.Items.Add("Inch");
                comboBoxToUnit.Items.Add("Foot");
                comboBoxToUnit.Items.Add("Yard");
            }


            else if (conversionType == "Weight")
            {
                // Weight Conversion Units
                comboBoxFromUnit.Items.Add("Milligram");
                comboBoxFromUnit.Items.Add("Gram");
                comboBoxFromUnit.Items.Add("Kilogram");
                comboBoxFromUnit.Items.Add("Pound");
                comboBoxFromUnit.Items.Add("Ounce");
                comboBoxFromUnit.Items.Add("Ton(metric)");

                comboBoxToUnit.Items.Add("Milligram");
                comboBoxToUnit.Items.Add("Gram");
                comboBoxToUnit.Items.Add("Kilogram");
                comboBoxToUnit.Items.Add("Pound");
                comboBoxToUnit.Items.Add("Ounce");
                comboBoxToUnit.Items.Add("Ton(metric)");

            }
            else if (conversionType == "Temperature")
            {
                // Temperature Conversion Units
                comboBoxFromUnit.Items.Add("Celsius");
                comboBoxFromUnit.Items.Add("Fahrenheit");
                comboBoxFromUnit.Items.Add("Kelvin");

                comboBoxToUnit.Items.Add("Celsius");
                comboBoxToUnit.Items.Add("Fahrenheit");
                comboBoxToUnit.Items.Add("Kelvin");
            }

            // Set default selection for "From" and "To" ComboBoxes
            comboBoxFromUnit.SelectedIndex = 0;
            comboBoxToUnit.SelectedIndex = 0;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double inputValue = 0;
            bool validInput = double.TryParse(textBoxInput.Text, out inputValue);

            if (!validInput)
            {
                MessageBox.Show("Please enter a valid number for conversion.");
                return;
            }

            double outputValue = 0;

            if (comboBoxConversionType.SelectedItem.ToString() == "Length")
            {
                // Length Conversion Logic
                string fromUnit = comboBoxFromUnit.SelectedItem.ToString();
                string toUnit = comboBoxToUnit.SelectedItem.ToString();

                if (fromUnit == "Metre")
                {
                    if (toUnit == "Kilometre") outputValue = inputValue / 1000;
                    else if (toUnit == "Inch") outputValue = inputValue * 39.3701;
                    else if (toUnit == "Foot") outputValue = inputValue * 3.28084;
                    else outputValue = inputValue;
                }
                // Add other conversion cases for kilometers, inches, and feet
            }
            else if (comboBoxConversionType.SelectedItem.ToString() == "Weight")
            {
                // Weight Conversion Logic
                string fromUnit = comboBoxFromUnit.SelectedItem.ToString();
                string toUnit = comboBoxToUnit.SelectedItem.ToString();

                if (fromUnit == "Gram")
                {
                    if (toUnit == "Kilogram") outputValue = inputValue / 1000;
                    else if (toUnit == "Pound") outputValue = inputValue * 0.00220462;
                    else if (toUnit == "Ounce") outputValue = inputValue * 0.035274;
                    else outputValue = inputValue;
                }
                // Add other conversion cases for kilograms, pounds, and ounces
            }
            else if (comboBoxConversionType.SelectedItem.ToString() == "Temperature")
            {
                // Temperature Conversion Logic
                string fromUnit = comboBoxFromUnit.SelectedItem.ToString();
                string toUnit = comboBoxToUnit.SelectedItem.ToString();

                if (fromUnit == "Celsius")
                {
                    if (toUnit == "Fahrenheit") outputValue = (inputValue * 9 / 5) + 32;
                    else if (toUnit == "Kelvin") outputValue = inputValue + 273.15;
                    else outputValue = inputValue;
                }
                // Add other conversion cases for Fahrenheit and Kelvin
            }

            textBoxOutput.Text = outputValue.ToString();
        }



        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxOutput.Clear();
            comboBoxFromUnit.SelectedIndex = -1;
            comboBoxToUnit.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.ShowDialog();
            this.Close();
        }

        private void buttonConvert_Click_1(object sender, EventArgs e)
        {
            // Input validation
            if (!double.TryParse(textBoxInput.Text, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }

            if (comboBoxConversionType.SelectedItem == null ||
                comboBoxFromUnit.SelectedItem == null ||
                comboBoxToUnit.SelectedItem == null)
            {
                MessageBox.Show("Please select conversion type and units");
                return;
            }

            string conversionType = comboBoxConversionType.SelectedItem.ToString();
            string fromUnit = comboBoxFromUnit.SelectedItem.ToString();
            string toUnit = comboBoxToUnit.SelectedItem.ToString();

            double outputValue = PerformConversion(conversionType, fromUnit, toUnit, inputValue);
            textBoxOutput.Text = outputValue.ToString("0.####"); // Display with up to 4 decimal places
        }

        private double PerformConversion(string conversionType, string fromUnit, string toUnit, double inputValue)
        {
            if (fromUnit == toUnit) return inputValue;

            switch (conversionType)
            {
                case "Length":
                    return ConvertLength(fromUnit, toUnit, inputValue);
                case "Weight":
                    return ConvertWeight(fromUnit, toUnit, inputValue);
                case "Temperature":
                    return ConvertTemperature(fromUnit, toUnit, inputValue);
                default:
                    return inputValue;
            }
        }

        //## Length Conversions (Metric and Imperial)
        private double ConvertLength(string fromUnit, string toUnit, double value)
        {
            // First, let's normalize unit names to handle common variations
            fromUnit = NormalizeUnitName(fromUnit);
            toUnit = NormalizeUnitName(toUnit);

            // Conversion factors to meters (base unit)
            var lengthFactors = new Dictionary<string, double>
        {
            {"Kilometer", 1000},     // 1 km = 1000 m
            {"Kilometre", 1000},     // Alternate spelling
            {"Meter", 1},
            {"Metre", 1},            // Alternate spelling
            {"Centimeter", 0.01},    // 1 cm = 0.01 m
            {"Millimeter", 0.001},   // 1 mm = 0.001 m
            {"Mile", 1609.344},      // 1 mile = 1609.344 m (exact)
            {"Yard", 0.9144},        // 1 yard = 0.9144 m (exact)
            {"Foot", 0.3048},        // 1 foot = 0.3048 m (exact)
            {"Inch", 0.0254},        // 1 inch = 0.0254 m (exact)
            {"NauticalMile", 1852}   // 1 nautical mile = 1852 m
        };

            // Check if units exist in our dictionary
            if (!lengthFactors.ContainsKey(fromUnit) || !lengthFactors.ContainsKey(toUnit))
            {
                MessageBox.Show($"Unsupported unit conversion: {fromUnit} to {toUnit}");
                return value;
            }

            // Convert to meters first, then to target unit
            double meters = value * lengthFactors[fromUnit];
            return meters / lengthFactors[toUnit];
        }

        // Helper method to handle unit name variations
        private string NormalizeUnitName(string unitName)
        {
            // Remove spaces and make case-insensitive
            unitName = unitName.Replace(" ", "").ToLower();

            // Standardize common variations
            return unitName switch
            {
                "km" or "kilometer" or "kilometre" => "Kilometer",
                "m" or "meter" or "metre" => "Meter",
                "cm" or "centimeter" or "centimetre" => "Centimeter",
                "mm" or "millimeter" or "millimetre" => "Millimeter",
                "mi" or "mile" => "Mile",
                "yd" or "yard" => "Yard",
                "ft" or "foot" or "feet" => "Foot",
                "in" or "inch" or "inches" => "Inch",
                "nmi" or "nauticalmile" => "NauticalMile",
                _ => unitName // return original if no match
            };
        }

        //## Weight Conversions
        private double ConvertWeight(string fromUnit, string toUnit, double value)
        {
            // All conversions go through grams as base unit
            var toGramFactors = new Dictionary<string, double>
            {
                {"Kilogram", 1000},
                {"Gram", 1},
                {"Milligram", 0.001},
                {"Pound", 453.592},
                {"Ounce", 28.3495},
                {"Ton (metric)", 1000000}
            };

            var fromGramFactors = new Dictionary<string, double>
            {
                {"Kilogram", 0.001},
                {"Gram", 1},
                {"Milligram", 1000},
                {"Pound", 1/453.592},
                {"Ounce", 1/28.3495},
                {"Ton (metric)", 1/1000000}
            };

            if (!toGramFactors.ContainsKey(fromUnit) || !fromGramFactors.ContainsKey(toUnit))
                return value;

            double grams = value * toGramFactors[fromUnit];
            return grams * fromGramFactors[toUnit];
        }

//## Temperature Conversions
        private double ConvertTemperature(string fromUnit, string toUnit, double value)
        {
            if (fromUnit == toUnit) return value;

            // Convert to Celsius first
            double celsius = fromUnit switch
            {
                "Celsius" => value,
                "Fahrenheit" => (value - 32) * 5 / 9,
                "Kelvin" => value - 273.15,
                _ => value
            };

            // Convert from Celsius to target unit
            return toUnit switch
            {
                "Celsius" => celsius,
                "Fahrenheit" => celsius * 9 / 5 + 32,
                "Kelvin" => celsius + 273.15,
                _ => value
            };
        }
        private void UC_Load(object sender, EventArgs e)
        {
            // Ensure the ComboBox is populated correctly
            comboBoxConversionType.Items.Clear(); // Clear any previous items (just to be safe)

            // Add Conversion Type options (Length, Weight, Temperature)
            comboBoxConversionType.Items.Add("Length");
            comboBoxConversionType.Items.Add("Weight");
            comboBoxConversionType.Items.Add("Temperature");

            // Set the default selected item (optional)
            comboBoxConversionType.SelectedIndex = 0; // Default to "Length"


        }




        //private void buttonconvert(object sender, eventargs e)
        //{

        //}
    }
}
