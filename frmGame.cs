namespace WinForm_StrategyGame
{
    public partial class frmGame : Form
    {
        Model model;

        public frmGame()
        {
            InitializeComponent();
            if(model == null)
                model = new Model();
            if(model.nations == null)
                model.nations = new List<Nation>();
            
            model.nations.Add(new Nation(){
                Id = 0,
                Name = "England",
                Army = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 1,
                Name = "Wales",
                Army = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 2,
                Name = "Scotland",
                Army = 0,
                Income = 0,
                Treasury = 1000
            });
            lblNationName.Text = model.nations[0].Name; //Index 0 daki ülke bizim ülkemiz
        }

        private void Exit_OnClick(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do you want to exit?", "Close App", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}