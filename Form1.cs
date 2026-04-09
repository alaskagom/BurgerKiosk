namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int totalCost = 0;

        private void btnreset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalPrice.Text = "총 금액: 0원";
        }
        
        private void grpchoice_Enter(object sender, EventArgs e)
        {
                if (rdoHamBurger.Checked)
            {
                totalCost+= 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost+= 4000;
            }
              else if (rdoChickenBurger.Checked)
            {
                totalCost+= 3000;
            }
        }
    }
}
