using System.Net.Http.Headers;

namespace WinForm_StrategyGame
{
    public partial class frmGame : Form
    {
        public Model model;
        public int selectedId; //Id
        private ITurn turn = new ITurnRepository();
        private IDefinition def = new IDefinitionRepository();
        private IPortre portre = new IPortreRepository();

        public frmGame()
        {
            InitializeComponent();
            if(model == null)
                model = new Model();
            def.DefinitionItems(model);
            model.EventTick = model.rnd.Next(5, 30); //New event tick
            def.NationsCreated(model);

            selectedId = 0;
            switch (selectedId){
                case 0:
                    model.province.NameId = "M";
                    model.province.FolderName = "munster";
                    model.province.FirstId = 1;
                    model.province.LastId = 1;
                break;
                case 1:
                    model.province.NameId = "L";
                    model.province.FolderName = "leinster";
                    model.province.FirstId = 1;
                    model.province.LastId = 1;
                break;
                case 2:
                    model.province.NameId = "U";
                    model.province.FolderName = "ulster";
                    model.province.FirstId = 1;
                    model.province.LastId = 1;
                break;
                case 3:
                    model.province.NameId = "C";
                    model.province.FolderName = "connaught";
                    model.province.FirstId = 1;
                    model.province.LastId = 1;
                break;
            }
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

        private void Dynasty_OnClick(object sender, EventArgs e)
        {
            if(pcbMap.Visible){
                pcbMap.Visible = false;
                portre.CreateDynastyTable(model, this);
            }
            else{
                pcbMap.Visible = true;
                portre.DeleteDynastyTable(model, this);
            }
        }
    }
}