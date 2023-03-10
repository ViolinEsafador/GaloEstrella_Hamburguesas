using GaloEstrella_Hamburguesas.Data;
using GaloEstrella_Hamburguesas.Models;


namespace GaloEstrella_Hamburguesas.Views;

public partial class BurgerItemPage : ContentPage
{
    Burger Item = new Burger();
    bool _flag;
    public BurgerItemPage()
    {
        InitializeComponent();
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        Item.Name = nameB.Text;
        Item.Description = descB.Text;
        Item.WithExtraCheese = _flag;
        App.PersonRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender,
   CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

}