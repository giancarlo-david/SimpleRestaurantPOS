namespace SimpleRestaurantPOS
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonReceipt = new System.Windows.Forms.Button();
            this.buttonDessert = new System.Windows.Forms.Button();
            this.buttonDrink = new System.Windows.Forms.Button();
            this.buttonSide = new System.Windows.Forms.Button();
            this.buttonEntree = new System.Windows.Forms.Button();
            this.buttonCombo = new System.Windows.Forms.Button();
            this.panelCombos = new System.Windows.Forms.Panel();
            this.buttonChickenStripsCombo = new System.Windows.Forms.Button();
            this.buttonHotdogCombo = new System.Windows.Forms.Button();
            this.buttonCheeseburgerCombo = new System.Windows.Forms.Button();
            this.panelEntrees = new System.Windows.Forms.Panel();
            this.buttonHotdog = new System.Windows.Forms.Button();
            this.buttonChickenStrips = new System.Windows.Forms.Button();
            this.buttonCheeseburger = new System.Windows.Forms.Button();
            this.panelDesserts = new System.Windows.Forms.Panel();
            this.buttonCake = new System.Windows.Forms.Button();
            this.buttonCookie = new System.Windows.Forms.Button();
            this.buttonIceCream = new System.Windows.Forms.Button();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.buttonShake = new System.Windows.Forms.Button();
            this.buttonBeer = new System.Windows.Forms.Button();
            this.buttonSoda = new System.Windows.Forms.Button();
            this.panelSides = new System.Windows.Forms.Panel();
            this.buttonChips = new System.Windows.Forms.Button();
            this.buttonMacCheese = new System.Windows.Forms.Button();
            this.buttonFries = new System.Windows.Forms.Button();
            this.CurrentReceiptView = new System.Windows.Forms.ListView();
            this.columnHeaderGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.panelCombos.SuspendLayout();
            this.panelEntrees.SuspendLayout();
            this.panelDesserts.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            this.panelSides.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMenu.Controls.Add(this.buttonReceipt);
            this.groupBoxMenu.Controls.Add(this.buttonDessert);
            this.groupBoxMenu.Controls.Add(this.buttonDrink);
            this.groupBoxMenu.Controls.Add(this.buttonSide);
            this.groupBoxMenu.Controls.Add(this.buttonEntree);
            this.groupBoxMenu.Controls.Add(this.buttonCombo);
            this.groupBoxMenu.Location = new System.Drawing.Point(18, 18);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMenu.Size = new System.Drawing.Size(276, 797);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // buttonReceipt
            // 
            this.buttonReceipt.BackColor = System.Drawing.Color.LightPink;
            this.buttonReceipt.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.buttonReceipt.Location = new System.Drawing.Point(9, 668);
            this.buttonReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReceipt.Name = "buttonReceipt";
            this.buttonReceipt.Size = new System.Drawing.Size(258, 118);
            this.buttonReceipt.TabIndex = 6;
            this.buttonReceipt.Text = "Print Receipt";
            this.buttonReceipt.UseVisualStyleBackColor = false;
            // 
            // buttonDessert
            // 
            this.buttonDessert.BackColor = System.Drawing.Color.LightBlue;
            this.buttonDessert.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.buttonDessert.Location = new System.Drawing.Point(9, 540);
            this.buttonDessert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDessert.Name = "buttonDessert";
            this.buttonDessert.Size = new System.Drawing.Size(258, 118);
            this.buttonDessert.TabIndex = 4;
            this.buttonDessert.Text = "Desserts";
            this.buttonDessert.UseVisualStyleBackColor = false;
            this.buttonDessert.Click += new System.EventHandler(this.buttonDessert_Click);
            // 
            // buttonDrink
            // 
            this.buttonDrink.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDrink.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.buttonDrink.Location = new System.Drawing.Point(9, 412);
            this.buttonDrink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDrink.Name = "buttonDrink";
            this.buttonDrink.Size = new System.Drawing.Size(258, 118);
            this.buttonDrink.TabIndex = 3;
            this.buttonDrink.Text = "Drinks";
            this.buttonDrink.UseVisualStyleBackColor = false;
            this.buttonDrink.Click += new System.EventHandler(this.buttonDrink_Click);
            // 
            // buttonSide
            // 
            this.buttonSide.BackColor = System.Drawing.Color.MintCream;
            this.buttonSide.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F);
            this.buttonSide.Location = new System.Drawing.Point(9, 285);
            this.buttonSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSide.Name = "buttonSide";
            this.buttonSide.Size = new System.Drawing.Size(258, 118);
            this.buttonSide.TabIndex = 2;
            this.buttonSide.Text = "Sides";
            this.buttonSide.UseVisualStyleBackColor = false;
            this.buttonSide.Click += new System.EventHandler(this.buttonSide_Click);
            // 
            // buttonEntree
            // 
            this.buttonEntree.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEntree.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntree.Location = new System.Drawing.Point(9, 157);
            this.buttonEntree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEntree.Name = "buttonEntree";
            this.buttonEntree.Size = new System.Drawing.Size(258, 118);
            this.buttonEntree.TabIndex = 1;
            this.buttonEntree.Text = "Entrees";
            this.buttonEntree.UseVisualStyleBackColor = false;
            this.buttonEntree.Click += new System.EventHandler(this.buttonEntree_Click);
            // 
            // buttonCombo
            // 
            this.buttonCombo.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonCombo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCombo.Location = new System.Drawing.Point(9, 29);
            this.buttonCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCombo.Name = "buttonCombo";
            this.buttonCombo.Size = new System.Drawing.Size(258, 118);
            this.buttonCombo.TabIndex = 0;
            this.buttonCombo.Text = "Combos";
            this.buttonCombo.UseVisualStyleBackColor = false;
            this.buttonCombo.Click += new System.EventHandler(this.buttonCombo_Click);
            // 
            // panelCombos
            // 
            this.panelCombos.BackColor = System.Drawing.Color.LightSalmon;
            this.panelCombos.Controls.Add(this.buttonChickenStripsCombo);
            this.panelCombos.Controls.Add(this.buttonHotdogCombo);
            this.panelCombos.Controls.Add(this.buttonCheeseburgerCombo);
            this.panelCombos.Location = new System.Drawing.Point(303, 48);
            this.panelCombos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCombos.Name = "panelCombos";
            this.panelCombos.Size = new System.Drawing.Size(604, 118);
            this.panelCombos.TabIndex = 1;
            this.panelCombos.Visible = false;
            // 
            // buttonChickenStripsCombo
            // 
            this.buttonChickenStripsCombo.Location = new System.Drawing.Point(406, 5);
            this.buttonChickenStripsCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChickenStripsCombo.Name = "buttonChickenStripsCombo";
            this.buttonChickenStripsCombo.Size = new System.Drawing.Size(192, 109);
            this.buttonChickenStripsCombo.TabIndex = 2;
            this.buttonChickenStripsCombo.Text = "Chicken Strips Combo";
            this.buttonChickenStripsCombo.UseVisualStyleBackColor = true;
            // 
            // buttonHotdogCombo
            // 
            this.buttonHotdogCombo.Location = new System.Drawing.Point(206, 5);
            this.buttonHotdogCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHotdogCombo.Name = "buttonHotdogCombo";
            this.buttonHotdogCombo.Size = new System.Drawing.Size(192, 109);
            this.buttonHotdogCombo.TabIndex = 1;
            this.buttonHotdogCombo.Text = "Hotdog Combo";
            this.buttonHotdogCombo.UseVisualStyleBackColor = true;
            // 
            // buttonCheeseburgerCombo
            // 
            this.buttonCheeseburgerCombo.Location = new System.Drawing.Point(4, 5);
            this.buttonCheeseburgerCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheeseburgerCombo.Name = "buttonCheeseburgerCombo";
            this.buttonCheeseburgerCombo.Size = new System.Drawing.Size(192, 109);
            this.buttonCheeseburgerCombo.TabIndex = 0;
            this.buttonCheeseburgerCombo.Text = "Cheeseburger Combo";
            this.buttonCheeseburgerCombo.UseVisualStyleBackColor = true;
            this.buttonCheeseburgerCombo.Click += new System.EventHandler(this.buttonCheeseburgerCombo_Click);
            // 
            // panelEntrees
            // 
            this.panelEntrees.BackColor = System.Drawing.Color.FloralWhite;
            this.panelEntrees.Controls.Add(this.buttonHotdog);
            this.panelEntrees.Controls.Add(this.buttonChickenStrips);
            this.panelEntrees.Controls.Add(this.buttonCheeseburger);
            this.panelEntrees.Location = new System.Drawing.Point(303, 175);
            this.panelEntrees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEntrees.Name = "panelEntrees";
            this.panelEntrees.Size = new System.Drawing.Size(604, 118);
            this.panelEntrees.TabIndex = 0;
            this.panelEntrees.Visible = false;
            // 
            // buttonHotdog
            // 
            this.buttonHotdog.Location = new System.Drawing.Point(206, 5);
            this.buttonHotdog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHotdog.Name = "buttonHotdog";
            this.buttonHotdog.Size = new System.Drawing.Size(192, 109);
            this.buttonHotdog.TabIndex = 5;
            this.buttonHotdog.Text = "Hotdog";
            this.buttonHotdog.UseVisualStyleBackColor = true;
            this.buttonHotdog.Click += new System.EventHandler(this.buttonHotdog_Click);
            // 
            // buttonChickenStrips
            // 
            this.buttonChickenStrips.Location = new System.Drawing.Point(406, 5);
            this.buttonChickenStrips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChickenStrips.Name = "buttonChickenStrips";
            this.buttonChickenStrips.Size = new System.Drawing.Size(192, 109);
            this.buttonChickenStrips.TabIndex = 4;
            this.buttonChickenStrips.Text = "Chicken Strips";
            this.buttonChickenStrips.UseVisualStyleBackColor = true;
            this.buttonChickenStrips.Click += new System.EventHandler(this.buttonChickenStrips_Click);
            // 
            // buttonCheeseburger
            // 
            this.buttonCheeseburger.Location = new System.Drawing.Point(4, 5);
            this.buttonCheeseburger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheeseburger.Name = "buttonCheeseburger";
            this.buttonCheeseburger.Size = new System.Drawing.Size(192, 109);
            this.buttonCheeseburger.TabIndex = 3;
            this.buttonCheeseburger.Text = "Cheeseburger";
            this.buttonCheeseburger.UseVisualStyleBackColor = true;
            this.buttonCheeseburger.Click += new System.EventHandler(this.buttonCheeseburger_Click);
            // 
            // panelDesserts
            // 
            this.panelDesserts.BackColor = System.Drawing.Color.SkyBlue;
            this.panelDesserts.Controls.Add(this.buttonCake);
            this.panelDesserts.Controls.Add(this.buttonCookie);
            this.panelDesserts.Controls.Add(this.buttonIceCream);
            this.panelDesserts.Location = new System.Drawing.Point(303, 558);
            this.panelDesserts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDesserts.Name = "panelDesserts";
            this.panelDesserts.Size = new System.Drawing.Size(604, 118);
            this.panelDesserts.TabIndex = 2;
            this.panelDesserts.Visible = false;
            // 
            // buttonCake
            // 
            this.buttonCake.Location = new System.Drawing.Point(406, 5);
            this.buttonCake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCake.Name = "buttonCake";
            this.buttonCake.Size = new System.Drawing.Size(192, 109);
            this.buttonCake.TabIndex = 3;
            this.buttonCake.Text = "Cake";
            this.buttonCake.UseVisualStyleBackColor = true;
            this.buttonCake.Click += new System.EventHandler(this.buttonCake_Click);
            // 
            // buttonCookie
            // 
            this.buttonCookie.Location = new System.Drawing.Point(206, 5);
            this.buttonCookie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCookie.Name = "buttonCookie";
            this.buttonCookie.Size = new System.Drawing.Size(192, 109);
            this.buttonCookie.TabIndex = 2;
            this.buttonCookie.Text = "Cookie";
            this.buttonCookie.UseVisualStyleBackColor = true;
            this.buttonCookie.Click += new System.EventHandler(this.buttonCookie_Click);
            // 
            // buttonIceCream
            // 
            this.buttonIceCream.Location = new System.Drawing.Point(4, 5);
            this.buttonIceCream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIceCream.Name = "buttonIceCream";
            this.buttonIceCream.Size = new System.Drawing.Size(192, 109);
            this.buttonIceCream.TabIndex = 1;
            this.buttonIceCream.Text = "Ice Cream";
            this.buttonIceCream.UseVisualStyleBackColor = true;
            this.buttonIceCream.Click += new System.EventHandler(this.buttonIceCream_Click);
            // 
            // panelDrinks
            // 
            this.panelDrinks.BackColor = System.Drawing.Color.Honeydew;
            this.panelDrinks.Controls.Add(this.buttonShake);
            this.panelDrinks.Controls.Add(this.buttonBeer);
            this.panelDrinks.Controls.Add(this.buttonSoda);
            this.panelDrinks.Location = new System.Drawing.Point(303, 431);
            this.panelDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(604, 118);
            this.panelDrinks.TabIndex = 0;
            this.panelDrinks.Visible = false;
            // 
            // buttonShake
            // 
            this.buttonShake.Location = new System.Drawing.Point(406, 5);
            this.buttonShake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShake.Name = "buttonShake";
            this.buttonShake.Size = new System.Drawing.Size(192, 109);
            this.buttonShake.TabIndex = 2;
            this.buttonShake.Text = "Shake";
            this.buttonShake.UseVisualStyleBackColor = true;
            this.buttonShake.Click += new System.EventHandler(this.buttonShake_Click);
            // 
            // buttonBeer
            // 
            this.buttonBeer.Location = new System.Drawing.Point(206, 5);
            this.buttonBeer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(192, 109);
            this.buttonBeer.TabIndex = 1;
            this.buttonBeer.Text = "Beer";
            this.buttonBeer.UseVisualStyleBackColor = true;
            this.buttonBeer.Click += new System.EventHandler(this.buttonBeer_Click);
            // 
            // buttonSoda
            // 
            this.buttonSoda.Location = new System.Drawing.Point(4, 5);
            this.buttonSoda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSoda.Name = "buttonSoda";
            this.buttonSoda.Size = new System.Drawing.Size(192, 109);
            this.buttonSoda.TabIndex = 0;
            this.buttonSoda.Text = "Soda";
            this.buttonSoda.UseVisualStyleBackColor = true;
            this.buttonSoda.Click += new System.EventHandler(this.buttonSoda_Click);
            // 
            // panelSides
            // 
            this.panelSides.BackColor = System.Drawing.Color.Ivory;
            this.panelSides.Controls.Add(this.buttonChips);
            this.panelSides.Controls.Add(this.buttonMacCheese);
            this.panelSides.Controls.Add(this.buttonFries);
            this.panelSides.Location = new System.Drawing.Point(303, 303);
            this.panelSides.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSides.Name = "panelSides";
            this.panelSides.Size = new System.Drawing.Size(604, 118);
            this.panelSides.TabIndex = 0;
            this.panelSides.Visible = false;
            // 
            // buttonChips
            // 
            this.buttonChips.Location = new System.Drawing.Point(406, 5);
            this.buttonChips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChips.Name = "buttonChips";
            this.buttonChips.Size = new System.Drawing.Size(192, 109);
            this.buttonChips.TabIndex = 2;
            this.buttonChips.Text = "Chips";
            this.buttonChips.UseVisualStyleBackColor = true;
            this.buttonChips.Click += new System.EventHandler(this.buttonChips_Click);
            // 
            // buttonMacCheese
            // 
            this.buttonMacCheese.Location = new System.Drawing.Point(206, 5);
            this.buttonMacCheese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMacCheese.Name = "buttonMacCheese";
            this.buttonMacCheese.Size = new System.Drawing.Size(192, 109);
            this.buttonMacCheese.TabIndex = 1;
            this.buttonMacCheese.Text = "Mac and Cheese";
            this.buttonMacCheese.UseVisualStyleBackColor = true;
            this.buttonMacCheese.Click += new System.EventHandler(this.buttonMacCheese_Click);
            // 
            // buttonFries
            // 
            this.buttonFries.Location = new System.Drawing.Point(4, 5);
            this.buttonFries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFries.Name = "buttonFries";
            this.buttonFries.Size = new System.Drawing.Size(192, 109);
            this.buttonFries.TabIndex = 0;
            this.buttonFries.Text = "Fries";
            this.buttonFries.UseVisualStyleBackColor = true;
            this.buttonFries.Click += new System.EventHandler(this.buttonFries_Click);
            // 
            // CurrentReceiptView
            // 
            this.CurrentReceiptView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGroup,
            this.columnHeaderType,
            this.columnHeaderPrice});
            this.CurrentReceiptView.FullRowSelect = true;
            this.CurrentReceiptView.HideSelection = false;
            this.CurrentReceiptView.Location = new System.Drawing.Point(951, 48);
            this.CurrentReceiptView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentReceiptView.MultiSelect = false;
            this.CurrentReceiptView.Name = "CurrentReceiptView";
            this.CurrentReceiptView.Size = new System.Drawing.Size(468, 622);
            this.CurrentReceiptView.TabIndex = 3;
            this.CurrentReceiptView.UseCompatibleStateImageBehavior = false;
            this.CurrentReceiptView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderGroup
            // 
            this.columnHeaderGroup.Text = "Group";
            this.columnHeaderGroup.Width = 100;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderType.Width = 150;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveItem.Location = new System.Drawing.Point(716, 695);
            this.buttonRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(192, 109);
            this.buttonRemoveItem.TabIndex = 4;
            this.buttonRemoveItem.Text = "Remove From Order";
            this.buttonRemoveItem.UseVisualStyleBackColor = false;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1035, 758);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(94, 38);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(1173, 754);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(148, 45);
            this.textBoxTotal.TabIndex = 6;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1173, 686);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 45);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "8.25%";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1035, 695);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tax:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(308, 695);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(191, 109);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 838);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.CurrentReceiptView);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.panelSides);
            this.Controls.Add(this.panelDesserts);
            this.Controls.Add(this.panelEntrees);
            this.Controls.Add(this.panelCombos);
            this.Controls.Add(this.groupBoxMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.groupBoxMenu.ResumeLayout(false);
            this.panelCombos.ResumeLayout(false);
            this.panelEntrees.ResumeLayout(false);
            this.panelDesserts.ResumeLayout(false);
            this.panelDrinks.ResumeLayout(false);
            this.panelSides.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonReceipt;
        private System.Windows.Forms.Button buttonDessert;
        private System.Windows.Forms.Button buttonDrink;
        private System.Windows.Forms.Button buttonSide;
        private System.Windows.Forms.Button buttonEntree;
        private System.Windows.Forms.Button buttonCombo;
        private System.Windows.Forms.Panel panelCombos;
        private System.Windows.Forms.Button buttonChickenStripsCombo;
        private System.Windows.Forms.Button buttonHotdogCombo;
        private System.Windows.Forms.Button buttonCheeseburgerCombo;
        private System.Windows.Forms.Panel panelEntrees;
        private System.Windows.Forms.Button buttonHotdog;
        private System.Windows.Forms.Button buttonChickenStrips;
        private System.Windows.Forms.Button buttonCheeseburger;
        private System.Windows.Forms.Panel panelDesserts;
        private System.Windows.Forms.Button buttonCake;
        private System.Windows.Forms.Button buttonCookie;
        private System.Windows.Forms.Button buttonIceCream;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.Button buttonShake;
        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.Button buttonSoda;
        private System.Windows.Forms.Panel panelSides;
        private System.Windows.Forms.Button buttonChips;
        private System.Windows.Forms.Button buttonMacCheese;
        private System.Windows.Forms.Button buttonFries;
        private System.Windows.Forms.ListView CurrentReceiptView;
        private System.Windows.Forms.ColumnHeader columnHeaderGroup;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
    }
}

