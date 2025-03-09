using MauiAppListaCompras.Models;
using System.Threading.Tasks;

namespace MauiAppListaCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("Produto Salvo", "Produto Inserido", "Ok");

		}catch (Exception ex)
		{
            await DisplayAlert("Ops", ex.Message, "ok");
        }
    }
}