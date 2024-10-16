namespace WinForm_StrategyGame;
using System.Drawing;
using System.Collections.Generic;

partial class frmGame
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
     
    public int displayX = 1280, displayY = 720;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(displayX, displayY);
        this.Text = "Game";
        CreateObjects();
        AddControls();
    }

    private void AddControls(){
        // Controls.Add(UIPanel);
        foreach(var items in allObjects){
            Controls.Add(items);
        }
    }

    private void CreateObjects(){
        if(lblNationName == null){lblNationName = new Label(); lblNationName.Name = "lblNationName"; lblNationName.Size = new Size(200, 50); lblNationName.Location = new Point(20, 20); lblNationName.BackColor = Color.LightGray; lblNationName.Font = new Font("Arial", 14); lblNationName.Text = "{Nation Name}"; lblNationName.TextAlign = ContentAlignment.MiddleCenter; allObjects.Add(lblNationName);}
        if(lblArmy == null){lblArmy = new Label(); lblArmy.Name = "lblArmy"; lblArmy.Size = new Size(200, 50); lblArmy.Location = new Point(240, 20); lblArmy.BackColor = Color.LightGray; lblArmy.Font = new Font("Arial", 14); lblArmy.Text = "{Army}"; lblArmy.TextAlign = ContentAlignment.MiddleCenter; allObjects.Add(lblArmy);}
        if(lblManPower == null){lblManPower = new Label(); lblManPower.Name = "lblManPower"; lblManPower.Size = new Size(200, 50); lblManPower.Location = new Point(460, 20); lblManPower.BackColor = Color.LightGray; lblManPower.Font = new Font("Arial", 14); lblManPower.Text = "{Manpower}"; lblManPower.TextAlign = ContentAlignment.MiddleCenter; allObjects.Add(lblManPower);}
        if(lblIncome == null){lblIncome = new Label(); lblIncome.Name = "lblIncome"; lblIncome.Size = new Size(200, 50); lblIncome.Location = new Point(680, 20); lblIncome.BackColor = Color.LightGray; lblIncome.Font = new Font("Arial", 14); lblIncome.Text = "{Income}"; lblIncome.TextAlign = ContentAlignment.MiddleCenter; allObjects.Add(lblIncome);}
        if(lblTreasury == null){lblTreasury = new Label(); lblTreasury.Name = "lblTreasury"; lblTreasury.Size = new Size(200, 50); lblTreasury.Location = new Point(900, 20); lblTreasury.BackColor = Color.LightGray; lblTreasury.Font = new Font("Arial", 14); lblTreasury.Text = "{Treasury}"; lblTreasury.TextAlign = ContentAlignment.MiddleCenter; allObjects.Add(lblTreasury);}
        
        if(btnExit == null){btnExit = new Button(); btnExit.Name = "btnExit"; btnExit.Size = new Size(90, 50); btnExit.Location = new Point(displayX - 110, 20); btnExit.BackColor = Color.IndianRed; btnExit.Font = new Font("Arial", 14); btnExit.Text = "Exit"; btnExit.TextAlign = ContentAlignment.MiddleCenter; btnExit.Click += Exit_OnClick; allObjects.Add(btnExit);}
        if(btnNext == null){btnNext = new Button(); btnNext.Name = "btnName"; btnNext.Size = new Size(280, 50); btnNext.Location = new Point(20, displayY - 70); btnNext.BackColor = Color.Bisque; btnNext.Font = new Font("Arial", 14); btnNext.Text = "Next Turn"; btnNext.TextAlign = ContentAlignment.MiddleCenter; btnNext.Click += Next_OnClick; allObjects.Add(btnNext);}
        if(btnAddArmy == null){btnAddArmy = new Button(); btnAddArmy.Name = "btnAddArmy"; btnAddArmy.Size = new Size(280, 50); btnAddArmy.Location = new Point(20, displayY - 140); btnAddArmy.BackColor = Color.Bisque; btnAddArmy.Font = new Font("Arial", 14); btnAddArmy.Text = "New Army"; btnAddArmy.TextAlign = ContentAlignment.MiddleCenter; btnAddArmy.Click += AddArmy_OnClick; allObjects.Add(btnAddArmy);}
    
        if(pcbMap == null){pcbMap = new PictureBox(); pcbMap.Name = "pcbMap"; pcbMap.Size = new Size(800, 475); pcbMap.Location = new Point(400, 180); pcbMap.BackColor = Color.White; pcbMap.Image = Image.FromFile("img/Map_Default.png"); pcbMap.SizeMode = PictureBoxSizeMode.CenterImage; allObjects.Add(pcbMap);}

        if(UIPanel == null){UIPanel = new Panel(); UIPanel.Name = "pnlUI"; UIPanel.Size = new Size(1280, 90); UIPanel.Location = new Point(0, 0); UIPanel.BackColor = Color.Gainsboro; allObjects.Add(UIPanel);}
        if(GamePanel == null){GamePanel = new Panel(); GamePanel.Name = "pnlGame"; GamePanel.Size = new Size(960, 630); GamePanel.Location = new Point(320, 90); GamePanel.BackColor = Color.Black; allObjects.Add(GamePanel);}
        if(ActionPanel == null){ActionPanel = new Panel(); ActionPanel.Name = "pnlAction"; ActionPanel.Size = new Size(320, 630); ActionPanel.Location = new Point(0, 90); ActionPanel.BackColor = Color.Gray; allObjects.Add(ActionPanel);}
    
    }

    Panel UIPanel, GamePanel, ActionPanel;
    public Label lblNationName, lblArmy, lblManPower, lblTreasury, lblIncome;
    Button btnExit, btnNext, btnAddArmy;
    public PictureBox pcbMap;
    List<Control> allObjects = new List<Control>();

    #endregion
}
