namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            grpchoice = new GroupBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpoption = new GroupBox();
            lstOrder = new ListBox();
            lblTotalPrice = new Label();
            grporder = new GroupBox();
            btnorder = new Button();
            btnreset = new Button();
            lbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("맑은 고딕", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl1.ForeColor = Color.Blue;
            lbl1.Location = new Point(55, 58);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(437, 62);
            lbl1.TabIndex = 9;
            lbl1.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 16.2F);
            rdoHamBurger.ForeColor = Color.Purple;
            rdoHamBurger.Location = new Point(82, 191);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(122, 42);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 16.2F);
            rdoBulgogiBurger.ForeColor = Color.Purple;
            rdoBulgogiBurger.Location = new Point(82, 308);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(178, 42);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 16.2F);
            rdoChickenBurger.ForeColor = Color.Purple;
            rdoChickenBurger.Location = new Point(82, 413);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(150, 42);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.햄버거1;
            pictureBox1.Location = new Point(290, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.불고기_버거1;
            pictureBox2.Location = new Point(290, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.치킨버거1;
            pictureBox3.Location = new Point(290, 413);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // grpchoice
            // 
            grpchoice.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpchoice.Location = new Point(66, 123);
            grpchoice.Name = "grpchoice";
            grpchoice.Size = new Size(374, 389);
            grpchoice.TabIndex = 10;
            grpchoice.TabStop = false;
            grpchoice.Text = "메뉴 선택";
            grpchoice.Enter += grpchoice_Enter;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(500, 171);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(114, 32);
            chkPotato.TabIndex = 3;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(500, 217);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(74, 32);
            chkCola.TabIndex = 4;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(500, 259);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(121, 32);
            chkCheese.TabIndex = 5;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.Location = new Point(500, 301);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(121, 32);
            chkSauce.TabIndex = 6;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpoption
            // 
            grpoption.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpoption.Location = new Point(488, 123);
            grpoption.Name = "grpoption";
            grpoption.Size = new Size(170, 373);
            grpoption.TabIndex = 11;
            grpoption.TabStop = false;
            grpoption.Text = "추가 옵션";
            grpoption.Enter += grpoption_Enter;
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(710, 164);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(262, 221);
            lstOrder.TabIndex = 13;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalPrice.ForeColor = Color.Blue;
            lblTotalPrice.Location = new Point(710, 403);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(184, 41);
            lblTotalPrice.TabIndex = 14;
            lblTotalPrice.Text = "총 금액: 0원";
            // 
            // grporder
            // 
            grporder.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grporder.Location = new Point(689, 123);
            grporder.Name = "grporder";
            grporder.Size = new Size(293, 332);
            grporder.TabIndex = 12;
            grporder.TabStop = false;
            grporder.Text = "주문 내역";
            grporder.Enter += grporder_Enter;
            // 
            // btnorder
            // 
            btnorder.Font = new Font("맑은 고딕", 12F);
            btnorder.Location = new Point(707, 496);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(122, 53);
            btnorder.TabIndex = 7;
            btnorder.Text = "주문하기";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("맑은 고딕", 12F);
            btnreset.Location = new Point(850, 496);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(122, 53);
            btnreset.TabIndex = 8;
            btnreset.Text = "초기화";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("맑은 고딕", 12F);
            lbl2.ForeColor = Color.Red;
            lbl2.Location = new Point(718, 462);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(183, 28);
            lbl2.TabIndex = 15;
            lbl2.Text = "메뉴를 선택하세요.";
            lbl2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 571);
            Controls.Add(lbl2);
            Controls.Add(btnreset);
            Controls.Add(btnorder);
            Controls.Add(lblTotalPrice);
            Controls.Add(lstOrder);
            Controls.Add(chkSauce);
            Controls.Add(chkCheese);
            Controls.Add(chkCola);
            Controls.Add(chkPotato);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rdoChickenBurger);
            Controls.Add(rdoBulgogiBurger);
            Controls.Add(rdoHamBurger);
            Controls.Add(lbl1);
            Controls.Add(grpchoice);
            Controls.Add(grpoption);
            Controls.Add(grporder);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox grpchoice;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpoption;
        private ListBox lstOrder;
        private Label lblTotalPrice;
        private GroupBox grporder;
        private Button btnorder;
        private Button btnreset;
        private Label lbl2;
    }
}
