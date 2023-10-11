namespace Payroll;

public partial class MainPage : ContentPage
{
	double payrate = 27.00;

	public MainPage()
	{
		InitializeComponent();
	}

    private void CalcButton_Clicked(object sender, EventArgs e)
    {
		//pull from the screen
		double hours = 0;
		try
		{
			hours = Convert.ToDouble(HoursEntry.Text);
		}
		catch (Exception)
		{
			hours = 0;
            DisplayAlert("Error", "Enter numbers only", "Bummer");

            //title, message,                button
            HoursEntry.Focus();	//focus is the object selected by the user
								//putrs the cursor into the box
			throw;
		}
		//should also surround with try catch
		//do something with item on screen
		double pay = hours * payrate;
		//display outpout
		PayLabel.Text = pay.ToString("$0.00");
        
    }
}

