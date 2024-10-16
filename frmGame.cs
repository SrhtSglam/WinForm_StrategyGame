namespace WinForm_StrategyGame
{
    public partial class frmGame : Form
    {
        public Model model;
        public int selectedId; //Id
        private ITurn turn = new ITurnRepository();
        Random rnd;

        public frmGame()
        {
            InitializeComponent();
            if(model == null)
                model = new Model();
            if(model.nations == null)
                model.nations = new List<Nation>();
            if(model.nations == null)
                model.nations = new List<Nation>();
            if(model.ownerProvinces == null)
                model.ownerProvinces = new List<Province>();
            if(rnd == null){
                rnd = new Random();
            }
            model.EventTick = rnd.Next(5, 30); //New event tick
            model.nations.Add(new Nation(){
                Id = 0,
                Name = "Munster",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 1,
                Name = "Connaught",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 2,
                Name = "Leinster",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 3,
                Name = "Ulster",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            switch (selectedId){
                case 0:
                    model.ownerProvinces.Add(new Province(){
                        NameId = "M",
                        FirstId = 1,
                        LastId = 1,
                        FolderName = "munster"
                    });
                break;
                case 1:
                    model.ownerProvinces.Add(new Province(){
                        NameId = "C",
                        FirstId = 1,
                        LastId = 1,
                        FolderName = "connaught"
                    });
                break;
                case 2:
                    model.ownerProvinces.Add(new Province(){
                        NameId = "L",
                        FirstId = 1,
                        LastId = 1,
                        FolderName = "leinster"
                    });
                break;
                case 3:
                    model.ownerProvinces.Add(new Province(){
                            NameId = "U",
                            FirstId = 1,
                            LastId = 1,
                            FolderName = "ulster"
                        });
                break;
            }
            selectedId = 0;
            turn.NextTurn(model, this);
        }

        private void Exit_OnClick(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do you want to exit?", "Close App", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void Next_OnClick(object sender, EventArgs e)
        {
            turn.NextTurn(model, this);
        }

        private void AddArmy_OnClick(object sender, EventArgs e)
        {
            turn.NewArmy(model, this);
        }
    }
}