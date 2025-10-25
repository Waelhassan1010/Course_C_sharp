using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void AddTofridgeBtn_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = NametextBox.Text,
                Type = TypeTextBox.Text,
                Weight = WeightNum.Value,
                KcalPer100g = KcalPer100gNum.Value,
                PricePer100g = PricePer100gNum.Value
            };
            string message= $@"
             {ingredient.Name}
             {ingredient.Type}
             {ingredient.Weight}
             {ingredient.PricePer100g}
             {ingredient.KcalPer100g}";
            MessageBox.Show(message);
        }
    }
}
public class Ingredient
{ 
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Weight { get; set; }
    public decimal KcalPer100g { get; set; }
    public decimal PricePer100g { get; set; }

}