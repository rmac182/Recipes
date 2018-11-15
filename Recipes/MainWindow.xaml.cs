using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Recipes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Ingredient> ingredients = new List<Ingredient>();
        

        public MainWindow()
        {
            InitializeComponent();
            FocusManager.SetFocusedElement(this, txtTitle);

            // When I add an item to the list(ingredients) here, It shows up on the list box it is binded too but.... (see line )
            ingredients.Add(new Ingredient { Amount = "AMOUNT", IngName = "INGREDIENT" });
            
            lbIngredients.ItemsSource = ingredients;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)txtTitle.Text != "" && (string)txtName.Text != "")
            {
                if (!(bool)chkBoxOption.IsChecked)
                {
                    recTitleName.Text = txtTitle.Text + "\n————————————————————————————————————————————————————————————\nBy: " + txtName.Text;
                }
                else
                {
                    recTitleName.Text = txtName.Text + "'s " + txtTitle.Text +
                        "\n————————————————————————————————————————————————————————————\n";
                }
            }
            else
            {
                MessageBox.Show("Recipe title and Written By are required fields.");
            }
        }

        private void BtnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (txtAmount.Text != "" && txtIngredient.Text != "")
            {
                
                 //...When the user adds am ingredient using this method here,  NOTHING!!!! Why???!!
                ingredients.Add(new Ingredient { Amount = txtAmount.Text, IngName = txtIngredient.Text });
                // I know it adds it because....
                MessageBox.Show(ingredients[0].Amount + " " + ingredients[0].IngName + "\n" + ingredients[1].Amount + " " + ingredients[1].IngName);

                txtIngredient.Text = "";
                txtAmount.Text = "";
            }
            else
            {
                MessageBox.Show("Must Enter an Ingredient and an Amount.");
            }
        }

        private void BtnEditIngredient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelIngredient_Click(object sender, RoutedEventArgs e)
        {
           

        }

       
    }
}

                
                




               
                  
