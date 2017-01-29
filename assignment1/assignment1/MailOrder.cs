using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class MailOrder : Form
    {
        private double _phours;
        private double _totalsalesamount;

        public MailOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Languagetranslate(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if(radio.Tag.ToString() == "french")
            {
                Calculate.Text = "Calculer";
                print.Text = "Impression";
                clear.Text = "Clair";
                EmployeeName.Text = "Le nom de l'employé ";
                employeeId.Text = "   ID employé : ";
                hoursWorked.Text = "Heures travaillées : ";
                totalSales.Text = "Ventes totales : ";
                salesBonus.Text = "     Bonus de vente : ";
                languages.Text = "Langues";
            }
            else if(radio.Tag.ToString() == "spanish")
            {
                Calculate.Text = "Calcular";
                print.Text = "Impresión";
                clear.Text = "Claro";
                EmployeeName.Text = "Nombre del empleado ";
                employeeId.Text = "   ID de empleado : ";
                hoursWorked.Text = "Horas trabajadas : ";
                totalSales.Text = "Ventas totales : ";
                salesBonus.Text = "     Bonificación de ventas : ";
                languages.Text = "Idiomas";
            }
            else
            {
                Calculate.Text = "Calculate";
                print.Text = "Print";
                clear.Text = "Clear";
                EmployeeName.Text = "Employee\'s Name";
                employeeId.Text = "   Employee ID :";
                hoursWorked.Text = "Hours Worked ";
                totalSales.Text = "Total Sales ";
                salesBonus.Text = "     Sales bonus : ";
                languages.Text = "Languages";
            }

        }
        /// <summary>
        /// sales calculate event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesCalculation(object sender, EventArgs e)
        {
            this.EmployeeName = EmployeeName.Text;

            this.employeeId = employeeId.Text;

            this.hoursWorked = hoursWorked.Text;

            this.totalSales = salesBonus.Text;

            //Below is the message box place your error message inside string.
            MessageBox.Show("Display your error here");

            Button button = sender as Button;
            //convert string values to the Doubles

            if (Isnumberandnegative(this.hoursWorked))
            {

                this._phours = (Convert.ToDouble(this.hoursWorked)) / 160;

            }

            if (Isnumberandnegative(this.totalSales))

            {

                this._totalsalesamount = (Convert.ToDouble(this.totalSales)) * (0.02);

            }

            this.salesBonus = (this._phours) * (this._totalsalesamount);

            salesBonus.Text = Convert.ToString(this.salesBonus);

        }

        private bool Isnumberandnegative(Label totalSales)
        {
            throw new NotImplementedException();
        }

        private
        bool
        Isnumberandnegative(string
        hoursandsales)

        {

            double _value;
            if (Double.TryParse(hoursandsales, out _value))

            {

                if (_value > 0)

                {

                    return
                    true;

                }

                else

                {

                    return
                    false;

                }

            }
            else

            {

                return
                false;

            }



        }
    }
