namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rdoHamBurger.CheckedChanged += (s, e) => UpdateOrder();
            rdoBulgogiBurger.CheckedChanged += (s, e) => UpdateOrder();
            rdoChickenBurger.CheckedChanged += (s, e) => UpdateOrder();
            chkPotato.CheckedChanged += (s, e) => UpdateOrder();
            chkCola.CheckedChanged += (s, e) => UpdateOrder();
            chkCheese.CheckedChanged += (s, e) => UpdateOrder();
            chkSauce.CheckedChanged += (s, e) => UpdateOrder();
        }

        int totalCost = 0;

        private void UpdateOrder()
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스500원");
            }

            lblTotalPrice.Text = "총 금액: " + (totalCost == 0 ? "0" : totalCost.ToString("#,0")) + "원";
        }

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

        }

        private void grpoption_Enter(object sender, EventArgs e)
        {

        }

        private void grporder_Enter(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lbl2.Visible = true;
                return;
            }
            else
            {
                lbl2.Visible = false;
                UpdateOrder();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Control[] choiceGroup = { rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger };
            Control[] optionGroup = { chkPotato, chkCola, chkCheese, chkSauce };

            if (keyData == Keys.Enter)
            {
                btnorder.PerformClick();
                return true;
            }

            if (keyData == Keys.Tab || keyData == (Keys.Tab | Keys.Shift))
            {
                bool forward = (keyData == Keys.Tab);

                if (Array.IndexOf(choiceGroup, ActiveControl) >= 0)
                {
                    if (forward) chkPotato.Focus();
                    else btnreset.Focus();
                    return true;
                }
                else if (Array.IndexOf(optionGroup, ActiveControl) >= 0)
                {
                    if (forward) btnorder.Focus();
                    else rdoHamBurger.Focus();
                    return true;
                }
                else if (ActiveControl == btnorder)
                {
                    if (forward) btnreset.Focus();
                    else chkPotato.Focus();
                    return true;
                }
                else if (ActiveControl == btnreset)
                {
                    if (forward) rdoHamBurger.Focus();
                    else btnorder.Focus();
                    return true;
                }
                else
                {
                    rdoHamBurger.Focus();
                    return true;
                }
            }

            if (keyData == Keys.Down || keyData == Keys.Right)
            {
                if (Array.IndexOf(choiceGroup, ActiveControl) >= 0)
                {
                    int idx = (Array.IndexOf(choiceGroup, ActiveControl) + 1) % choiceGroup.Length;
                    choiceGroup[idx].Focus();
                    return true;
                }
                else if (Array.IndexOf(optionGroup, ActiveControl) >= 0)
                {
                    int idx = (Array.IndexOf(optionGroup, ActiveControl) + 1) % optionGroup.Length;
                    optionGroup[idx].Focus();
                    return true;
                }
            }

            if (keyData == Keys.Up || keyData == Keys.Left)
            {
                if (Array.IndexOf(choiceGroup, ActiveControl) >= 0)
                {
                    int idx = (Array.IndexOf(choiceGroup, ActiveControl) - 1 + choiceGroup.Length) % choiceGroup.Length;
                    choiceGroup[idx].Focus();
                    return true;
                }
                else if (Array.IndexOf(optionGroup, ActiveControl) >= 0)
                {
                    int idx = (Array.IndexOf(optionGroup, ActiveControl) - 1 + optionGroup.Length) % optionGroup.Length;
                    optionGroup[idx].Focus();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
