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
            List<Ingredient> ingredients = new List<Ingredient>();
            Ingredient i1 = new Ingredient { Name = "apple", Type = "Fruit", Weight = 100, KcalPer100g = 324, PricePer100g = 312 };
            Ingredient i2 = new Ingredient { Name = "bananan", Type = "Fruit", Weight = 150, KcalPer100g = 500, PricePer100g = 312 };
            Ingredient i3 = new Ingredient { Name = "pinaple", Type = "Fruit", Weight = 200, KcalPer100g = 400, PricePer100g = 312 };


            ingredients.Add(i1);
            ingredients.Add(i2);
            ingredients.Add(i3);
            string message = " ";
            //foreach (Ingredient INg1 in ingredients)
            //{
            //    message += $@" 
            //{INg1.Name} {INg1.Type} {INg1.Weight} {INg1.KcalPer100g} {INg1.PricePer100g}";


            //}
            ingredients.ForEach(INg1 => { message += $@" 
            {INg1.Name} {INg1.Type} {INg1.Weight} {INg1.KcalPer100g} {INg1.PricePer100g}"; });
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